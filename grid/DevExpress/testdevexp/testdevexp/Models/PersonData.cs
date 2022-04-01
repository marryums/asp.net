using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testdevexp.Models
{
    static class PersonData
    {
        public static List<SamplePerson> Persons = new List<SamplePerson>()
        {
            new SamplePerson
            {
                PersonId=1,
                Name = "Shujaat",
                CNIC = "8120254845517",
                CNICExpiryDate = new DateTime(2022, 7, 4),
                Country = "Pakistan",
                City = "Isbd"
            },
            new SamplePerson
            {
                PersonId=2,
                Name = "Ali",
                CNIC = "8120254845517",
                CNICExpiryDate = new DateTime(2022, 7, 4),
                Country = "Pakistan",
                City = "Isbd"
            },
            new SamplePerson
            {
                PersonId=3,
                Name = "Haris",
                CNIC = "8120254845517",
                CNICExpiryDate = new DateTime(2022, 7, 4),
                Country = "Pakistan",
                City = "Isbd"
            }
        };

    }
}
