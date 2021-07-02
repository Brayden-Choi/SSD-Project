using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIST.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
