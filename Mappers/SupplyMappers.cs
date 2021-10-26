using buildxact_supplies.Entities;
using buildxact_supplies.Helper;
using buildxact_supplies.Model;

namespace buildxact_supplies.Mappers
{
    //used to return Supply from other classes
    public static class SupplyMappers
    {
        public static Supply Parse(HumphriesSupply data)
        {
            return new Supply()
            {
                Id = data.Id.ToString(),
                OriginalCurrency = "AUD",
                DisplayedCurrency = "AUD",
                Description = data.Description,
                Unit = data.Unit,
                UnitPrice = data.Price,
                ParentFile = "humphries.csv"
            };
        }
        public static Supply Parse(MegaCorpSupply data)
        {
            return new Supply()
            {
                Id = data.Id.ToString(),
                Description = data.Description,
                UnitPrice = data.PriceInCents,
                OriginalCurrency = "USD",
                DisplayedCurrency = "AUD",
                Unit = data.Uom,
                ParentFile = "megacorp.json"
            };
        }
    }
}
