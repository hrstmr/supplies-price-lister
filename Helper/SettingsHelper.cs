using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace buildxact_supplies.Helper
{
    // It will be used once app setting increases in size
    public static class SettingsHelper
    {
        private static readonly IConfigurationRoot _configuration;
        static SettingsHelper()
        {
            _configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true).AddEnvironmentVariables().Build();
        }

        //IEnumerable cuz there can be multiple conversionrate in future
        public static IEnumerable<ConversionRate> GetConversionRates()
        {
            return new List<ConversionRate>()
            {
                new ConversionRate
                {
                    FromCurrency = "AUD",
                    ToCurrency = "USD",
                    Rate = decimal.Parse(_configuration["audUsdExchangeRate"])
                }
            };
        }

    }
}