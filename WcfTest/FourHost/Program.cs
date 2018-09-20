using FourService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FourHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost ReqReplyHost = new ServiceHost(typeof(ReqReply)))
            using (ServiceHost CustomerHost = new ServiceHost(typeof(Customer)))
            {
                ReqReplyHost.Opened += delegate
                {
                    Console.WriteLine("请求响应通讯服务已经启动，按任意键终止！");
                };

                ReqReplyHost.Open();

                CustomerHost.Opened += delegate
                {
                    Console.WriteLine("请求响应通讯服务已经启动，按任意键终止！");
                };

                CustomerHost.Open();

                Console.Read();
            }
        }
    }
}
