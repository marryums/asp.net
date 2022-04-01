using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdevexp.Models {
    public class SamplePerson
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }
        public DateTime CNICExpiryDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }        
    }
}
