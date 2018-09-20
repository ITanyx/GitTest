using FourteenContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourteenService
{
    public class FirstService : IFirstService
    {
        public string GetData()
        {
            return "123456";
        }
    }
}
