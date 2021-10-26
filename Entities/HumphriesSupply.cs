using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace buildxact_supplies.Entities
{
    public class HumphriesSupply
    {
        //name attributes to map the csv field to HumphriesSupply property
        [Name("identifier")]
        public string Id { get; set; } //its not mentioned in the doc that this is unique
        [Name("desc")]
        public string Description { get; set; }
        [Name("unit")]
        public string Unit { get; set; }
        [Name("costAUD")]
        public decimal Price { get; set; }
    }
}
