using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourService
{
    public class Customer : ICustomer
    {
        public string Show(string name)
        {
            System.Threading.Thread.Sleep(10000);
            return "Hello " + name;
        }
    }
}
