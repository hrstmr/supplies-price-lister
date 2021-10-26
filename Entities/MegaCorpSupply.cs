using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Entities
{
    public class MegaCorpSupply
    {
        //name attributes to map the json field to MegaCorpSupply property
        [JsonProperty("id")]
        public int Id { get; set; } //mentioned in the readme that this should be unique hence Guid
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("uom")]
        public string Uom { get; set; }
        [JsonProperty("priceInCents")]
        public int PriceInCents { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
        [JsonProperty("materialType")]
        public string MaterialType { get; set; }
    }
}
