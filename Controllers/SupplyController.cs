using buildxact_supplies.Model;
using buildxact_supplies.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buildxact_supplies
{
    public class SupplyController
    {
        private readonly ISupplyRepository _supplyRepository;
        public SupplyController(ISupplyRepository supplyRepository)
        {
            _supplyRepository = supplyRepository;
        }

        // This should be an seperate class
        public async void DisplaySupplies()
        {
            var supplies = await GetAllSupply();
            foreach (var supply in supplies)
            {
                var currencySymbol = "$";
                Console.WriteLine($"{supply.Id},{supply.Description},{currencySymbol}{decimal.Round(supply.UnitPrice, 2)}");
            }
            Console.ReadLine();
        }

        public async Task<IEnumerable<Supply>> GetAllSupply()
        {
            //find a way avoid hardcoping the sort and use sort Request
            var supplies = await _supplyRepository.GetAll();
            return supplies.OrderByDescending(s => s.UnitPrice);
        }
    }
}
