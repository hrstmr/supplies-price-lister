using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Helper
{
    public class ConversionRate
    {
        public string FromCurrency { get; set; } // can be updated to enum as currency values are predefined
        public string ToCurrency { get; set; } // can be updated to enum as currency values are predefined
        public decimal Rate { get; set; }
    }
}
