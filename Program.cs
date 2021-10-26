using buildxact_supplies.Helper;
using Newtonsoft.Json;
using System;

namespace SuppliesPriceLister
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = SettingsHelper.GetConversionRates();
            Console.WriteLine(JsonConvert.SerializeObject(settings, Formatting.Indented));
            // Your solution begins here
        }
    }
}
