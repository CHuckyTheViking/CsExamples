using System;
using System.Collections.Generic;
using System.Text;
using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {
            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "1007500", Name = "Apple Airpods 2019", Description = "Airpods med laddning" });
            output.Add(new Product { Id = "2337522", Name = "Scooter", Description = "Går som fan" });
            output.Add(new Product { Id = "3337512", Name = "Skateboard", Description = "Rullar som aldrig förr" });

            output.Add(new License { Id = "10101000000", Name = "Windows 10", Description = "Programvara", NumberOfLicenses = 1 });
            output.Add(new License { Id = "10010011111", Name = "Windows 9", Description = "Programvara", NumberOfLicenses = 5 });

            return output;

        }


    }
}
