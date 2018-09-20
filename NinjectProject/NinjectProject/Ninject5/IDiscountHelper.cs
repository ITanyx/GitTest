using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectProject.Ninject5
{
    //折扣计算接口
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }
}
