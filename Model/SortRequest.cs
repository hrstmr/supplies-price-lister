using System;
using System.Collections.Generic;
using System.Text;

namespace buildxact_supplies.Model
{
    public class SortRequest
    {
        public string Skip { get; set; }
        public string Take { get; set; }
        public string SortOn { get; set; }
        public string SortDir { get; set; }
    }
}
