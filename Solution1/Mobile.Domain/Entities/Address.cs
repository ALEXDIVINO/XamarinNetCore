using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Domain.Entities
{
    public class Address
    {

        public string ZipCode { get; set; }

        public string Number { get; set; }

        public string Street { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }


    }
}
