using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourClient.ServiceReference1;
using FourClient.ServiceReference2;

namespace FourClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ReqReplyClient ReqReply = null;
            CustomerClient Customer = null;
            try
            {
                Console.WriteLine("****************SayHello请求响应通讯服务示例*******************");
                ReqReply = new ReqReplyClient();

                Console.WriteLine("方法调用前时间：" + System.DateTime.Now);
                Console.WriteLine(ReqReply.SayHello("SayHello"));
                Console.WriteLine("方法调用后时间：" + System.DateTime.Now);

                ReqReply.Close();

                Console.WriteLine("****************Show请求响应通讯服务示例*******************");
                Customer = new CustomerClient();

                Console.WriteLine("方法调用前时间：" + System.DateTime.Now);
                Console.WriteLine(Customer.Show("Show"));
                Console.WriteLine("方法调用后时间：" + System.DateTime.Now);

                ReqReply.Close();
            }
            catch (Exception)
            {
                if (ReqReply != null)
                {
                    ReqReply.Abort();
                }

                if (Customer != null)
                {
                    Customer.Abort();
                }
            }

            Console.Read();
        }
    }
}
