using buildxact_supplies.Entities;
using buildxact_supplies.Helper;
using buildxact_supplies.Mappers;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System;
using buildxact_supplies.Helper;
using buildxact_supplies.Repositories;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using buildxact_supplies;
namespace SuppliesPriceLister
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureDependancies();
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
