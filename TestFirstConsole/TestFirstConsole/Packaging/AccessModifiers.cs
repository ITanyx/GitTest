using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole.Packaging
{
    public class AccessModifiers
    {
        public long Id { get; set; }

        protected string Name { get; set; }

        internal int Age { get; set; }

        private double Height { get; set; }

        internal protected int QQ { get; set; }
    }

    internal class ChildrenAccessModifiers : AccessModifiers
    {
        public void Method()
        {
            
        }
    }
}
