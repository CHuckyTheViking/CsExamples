using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace C16_WorkerService
{
    public class Worker : BackgroundService
    {

        private readonly ILogger<Worker> _logger;
        private HttpClient client;
        private string url = "https://google.com";
        private HttpResponseMessage result;


        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
           
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new HttpClient();
            _logger.LogInformation("The service has been started.");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("The service has been stopped.");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    result = await client.GetAsync(url);
                    if (result.IsSuccessStatusCode)
                        _logger.LogInformation($"The website ({url}) is up. Status Code = {result.StatusCode}");
                    else
                        _logger.LogInformation($"The website ({url}) us down. Status Code = {result.StatusCode}");
                }
                catch (Exception ex)
                {
                    _logger.LogInformation($"Failed. The website ({url}) - {ex.Message}");
                    
                }
                

                await Task.Delay(5*1000, stoppingToken);
            }
        }
    }
}
