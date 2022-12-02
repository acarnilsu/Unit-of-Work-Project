using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_of_Work_EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public string Iban { get; set; }
    }
}
