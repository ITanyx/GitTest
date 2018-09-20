using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole
{
    [AttributeUsage(AttributeTargets.All)]
    public class CustomerAttribute : Attribute
    {
        public CustomerAttribute()
        {
            
        }

        public override bool Match(object obj)
        {
            return false;
        }
    }
}
