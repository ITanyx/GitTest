using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole.EventStandard
{
    /// <summary>
    /// 事件发行者（Publisher）
    /// </summary>
    public class iPhone8
    {
        /// <summary>
        /// 发布个事件
        /// </summary>
        public event EventHandler<PriceChangeEventArgs> PriceChange;
        //PriceChangeEventHandler
        protected virtual void OnPriceChanged(PriceChangeEventArgs e)
        {
            if (this.PriceChange != null)
                this.PriceChange.Invoke(this, e);
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value)
                    return;
                decimal oldPrice = price;
                price = value;
                // 如果调用列表不为空，则触发。
                this.OnPriceChanged(new PriceChangeEventArgs(oldPrice, price));
            }
        }
    }
}
