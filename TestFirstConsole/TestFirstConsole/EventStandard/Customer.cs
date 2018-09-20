using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole.EventStandard
{
    /// <summary>
    /// 订户：事件主题的关注者
    /// </summary>
    public class Customer
    {
        public void iPhone8_PriceChange(object sender, PriceChangeEventArgs e)
        {
            Console.WriteLine("年终大促销，iPhone 8 只卖 " + e.NewPrice + " 元， 原价 " + e.OldPrice + " 元，果断买！");
        }
    }
}
