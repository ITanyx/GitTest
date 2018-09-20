using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole.EventStandard
{
    /// <summary>
    /// 事件的注册(初始化)
    /// </summary>
    public class EventRegister
    {
        private iPhone8 _iphone = null;
        public int s = 10;
        public static int x = 100;

        //private Customer _customer = null;
        //private Businessman _businessman = null;

        /// <summary>
        /// 
        /// </summary>
        public void Init()
        {
            this._iphone = new iPhone8();
            Customer customer = new Customer();
            this._iphone.PriceChange += customer.iPhone8_PriceChange;

            Businessman businessman = new Businessman();
            this._iphone.PriceChange += businessman.iPhone8_PriceChange;
        }

        public void SetPrice(decimal price)
        {
            this._iphone.Price = price;
        }

    }
}
