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
            var supplies = await GetAllSupply(new SortRequest()
            {
                SortOn = "UnitPrice",
                SortDir = "desc",
            });

            var currencySymbol = "$"; //This can be updated once currency class is added
            foreach (var supply in supplies)
            {
                Console.WriteLine($"{supply.Id},{supply.Description},{currencySymbol}{decimal.Round(supply.UnitPrice, 2)}");
            }
            Console.ReadLine();
        }

        public async Task<IEnumerable<Supply>> GetAllSupply(SortRequest request)
        {
            //find a way avoid hardcoping the sort and use sort Request
            var supplies = await _supplyRepository.GetAll();
            return supplies.OrderByDescending(s => s.UnitPrice);
        }
    }
}
