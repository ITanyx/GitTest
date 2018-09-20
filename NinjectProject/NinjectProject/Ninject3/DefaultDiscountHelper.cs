using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectProject.Ninject3
{
    //默认折扣计算器
    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (1m / 10m * totalParam));
        }
    }
}
