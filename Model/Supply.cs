using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Model
{
    public class Supply : BaseModel
    {
        //after convertion from csv & json id might not be unique, need more context about the file, can filename+Id be unique or can these file or duplicate file can be generated over time
        //public string Id { get; set; }
        public string OriginalCurrency { get; set; } //Can be a currency class with {code:"AUD" , symbol:"$", desc:"australian dollar"}
        public string DisplayedCurrency { get; set; } //Can be a currency class with {code:"AUD" , symbol:"$", desc:"australian dollar"}
        public string Description { get; set; }
        public string Unit { get; set; } //Can be a Unit class with {type:"Length",name:"meter",symbol:"m"}
        public decimal UnitPrice { get; set; }
        public string ParentFile { get; set; } // stores the original file name
    }
}
