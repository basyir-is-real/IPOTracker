using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPOTracker
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }
        public string Ticker { get; set; }
        public DateTime ListingDate { get; set; }
        public decimal ListingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}
