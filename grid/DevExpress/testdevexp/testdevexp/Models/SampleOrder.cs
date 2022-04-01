using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdevexp.Models {
    public class SampleOrder {
        public string CustomField { get; set; }
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
    }
}
