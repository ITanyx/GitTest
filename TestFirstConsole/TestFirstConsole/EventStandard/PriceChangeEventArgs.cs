using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole.EventStandard
{
    /// <summary>
    /// 事件参数
    /// </summary>
    public class PriceChangeEventArgs: EventArgs
    {
        public int Id { get; set; }
        public readonly decimal OldPrice;
        public readonly decimal NewPrice;
        public PriceChangeEventArgs(decimal oldPrice, decimal newPrice)
        {
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }


}
