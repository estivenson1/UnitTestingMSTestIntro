using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMSTestIntro
{
    public class Customer
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
    }
    public class CollectionsSample
    {
        public static Customer GetCustomer(Customer[] customers, int index)
        {
            return customers[index];
        }
    }
}
