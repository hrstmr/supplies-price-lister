using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Entities
{
    public class MegaCorpPartner
    {
        //name attributes to map the json field to MegaCorpPartner property
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("partnerType")]
        public string PartnerType { get; set; }
        [JsonProperty("partnerAddress")]
        public string PartnerAddress { get; set; }
        [JsonProperty("supplies")]
        public List<MegaCorpSupply> Supplies { get; set; }
    }
}
