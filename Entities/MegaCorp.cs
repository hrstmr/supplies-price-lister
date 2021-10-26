using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Entities
{
    public class MegaCorp
    {
        //name attributes to map the csv field to MegaCorp property
        [JsonProperty("partners")]
        public List<MegaCorpPartner> Partners { get; set; }
    }
}
