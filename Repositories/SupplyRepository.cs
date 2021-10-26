using buildxact_supplies.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using buildxact_supplies.Entities;
using buildxact_supplies.Mappers;
using buildxact_supplies.Helper;
using System.Text.Json;
using Newtonsoft.Json;

namespace buildxact_supplies.Repositories
{
    public class SupplyRepository : ISupplyRepository
    {
        public async Task<IEnumerable<Supply>> GetAll()
        {
            var AllSupplies = new List<Supply>();
            var HumphriesSupplies = await GetFromHumphriesCSV("\\humphries.csv");
            var MegaCorpSupplies = await GetFromMegaCorpJSON("\\megacorp.json");
            AllSupplies.AddRange(HumphriesSupplies);
            AllSupplies.AddRange(MegaCorpSupplies);
            return AllSupplies;
        }

        public Task<IEnumerable<Supply>> GetFromFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Supply>> GetFromHumphriesCSV(string filePath)
        {
            //using csvHelper to prevent writing custom code
            TextReader fileReader = File.OpenText($"{SettingsHelper.GetFileLocation()}{filePath}");
            var HumphriesData = new CsvReader(fileReader, new CsvConfiguration(CultureInfo.InvariantCulture));
            // For some reason GetRecordsAsync is not working look into it if time left 
            return HumphriesData.GetRecords<HumphriesSupply>().Select(SupplyMappers.Parse);
        }

        public async Task<IEnumerable<Supply>> GetFromMegaCorpJSON(string filePath)
        {
            TextReader fileReader = File.OpenText($"{SettingsHelper.GetFileLocation()}{filePath}");
            string json = await fileReader.ReadToEndAsync();
            var MegaCorpData = JsonConvert.DeserializeObject<MegaCorp>(json);
            //select many to flatten the list
            return MegaCorpData.Partners.SelectMany(p => p.Supplies).Select(SupplyMappers.Parse);
        }
    }
}
