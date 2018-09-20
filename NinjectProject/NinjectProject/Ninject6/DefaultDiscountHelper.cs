using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectProject.Ninject6
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
        private decimal discountRate;

        public DefaultDiscountHelper(decimal discountParam)
        {
            discountRate = discountParam;
        }

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (discountRate / 10m * totalParam));
        }
    }
}
