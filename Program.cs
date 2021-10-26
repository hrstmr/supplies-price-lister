using buildxact_supplies;
using buildxact_supplies.Entities;
using buildxact_supplies.Helper;
using buildxact_supplies.Mappers;
using buildxact_supplies.Repositories;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            var serviceProvider = ConfigureDependancies();
            var supplyController = serviceProvider.GetService<SupplyController>();
            supplyController.DisplaySupplies();
            Console.ReadLine();
        }

        public static IServiceProvider ConfigureDependancies()
        {
            var services = new ServiceCollection();
            services.AddSingleton<SupplyController>();
            services.AddSingleton<ISupplyRepository, SupplyRepository>();
            return services.BuildServiceProvider();
        }
    }
}
