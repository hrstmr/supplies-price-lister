using buildxact_supplies.Entities;
using buildxact_supplies.Helper;
using buildxact_supplies.Model;

namespace buildxact_supplies.Mappers
{
    //used to return SupplyMappers from other classes
    public static class SupplyMappers
    {
        public static Supply Parse(HumphriesSupply data)
        {
            return new Supply()
            {
                Id = data.Id.ToString(),
                Currency = "AUD",
                Description = data.Description,
                Unit = data.Unit,
                UnitPrice = data.Price,
            };
        }
    }
}
