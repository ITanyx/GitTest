using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectProject.Ninject4
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal DiscountSize { get; set; }

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (DiscountSize / 10m * totalParam));
        }
    }
}
