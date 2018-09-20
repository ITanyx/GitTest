using SixService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SixHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost ReqReplyHost = new ServiceHost(typeof(ReqReply)))
            {
                ReqReplyHost.Opened += delegate
                {
                    Console.WriteLine("请求响应通讯服务已经启动，按任意键终止！");
                };

                ReqReplyHost.Open();
                Console.Read();
            }
        }
    }
}
