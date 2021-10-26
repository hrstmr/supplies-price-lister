using buildxact_supplies.Entities;
using buildxact_supplies.Helper;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SuppliesPriceLister
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = SettingsHelper.GetConversionRates();
            //var display = JsonConvert.SerializeObject(settings, Formatting.Indented);
            //Console.WriteLine(display);

            //TextReader fileReader = File.OpenText($"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\humphries.csv");
            //var HumphriesData = new CsvReader(fileReader, new CsvConfiguration(CultureInfo.InvariantCulture));
            //var result = HumphriesData.GetRecords<HumphriesSupply>();
            //Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));


            TextReader fileReader = File.OpenText($"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\megacorp.json");
            string json = fileReader.ReadToEnd();
            Console.WriteLine(json);
            var MegaCorpData = JsonConvert.DeserializeObject<MegaCorp>(json);
            //select many to flatten the list
            var result = MegaCorpData.Partners.SelectMany(p => p.Supplies);
            Console.WriteLine(result);

            // Your solution begins here
        }
    }
}
