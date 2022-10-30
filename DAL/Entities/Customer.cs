using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public Address address { get; set; }
    }
}
