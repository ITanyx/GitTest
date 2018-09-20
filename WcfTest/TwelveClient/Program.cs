using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TwelveClient.MessageExchangeServiceRef;

namespace TwelveClient
{
    public class CallBackHandler : IMessageExchangeCallback
    {
        public void Receive(string message)
        {
            Console.WriteLine("客户端监听服务端接收的消息：" + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new CallBackHandler());
            MessageExchangeClient proxy = new MessageExchangeClient(instanceContext);
            proxy.Send("Wcf Duplex");

            Console.Read();
        }
    }
}
