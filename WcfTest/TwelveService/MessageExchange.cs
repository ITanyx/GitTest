using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TwelveService
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class MessageExchange : IMessageExchange
    {
        public void Send(string message)
        {
            Console.WriteLine("服务端监听客户端发出的消息：" + message);
            Callback.Receive(message);
        }

        IMessageExchangeCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IMessageExchangeCallback>();
            }
        }
    }
}
