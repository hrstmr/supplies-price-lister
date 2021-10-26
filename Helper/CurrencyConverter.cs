using buildxact_supplies.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace buildxact_supplies.Helper
{
    public static class CurrencyConverter
    {
        public static decimal Convert(string from, string to, decimal value)
        {
            //as long as both currencies are available from and to shouldnt matter
            var conversionRate = SettingsHelper.GetConversionRates()
                .Where(cr => (cr.FromCurrency == from && cr.ToCurrency == to) || (cr.FromCurrency == to && cr.ToCurrency == from))
                .FirstOrDefault();
            //calculation based on rate available either
            return conversionRate.FromCurrency == from ? value * conversionRate.Rate : value / conversionRate.Rate;
        }
    }
}
