using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XfrogWCFService
{
    public class FirstService : IFirstService
    {
        string IFirstService.GetData(String name)
        {
            return String.Format("Hello {0},Welcome To WCF!", name);
        }
    }
}
