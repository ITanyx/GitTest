using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourteenHost
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tencent.OA.FAF.WCF.ServiceHostManager.ServiceStartEvent += ServiceStart;
                Tencent.OA.FAF.WCF.ServiceHostManager.ServiceStopEvent += ServiceStop;
                Tencent.OA.FAF.WCF.ServiceHostManager.StartHost();

                Console.WriteLine("服务启动成功.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }

        public static void ServiceStart(System.ServiceModel.ServiceHost host)
        {
            Console.WriteLine(string.Format("服务启动：{0}", host.Description.Name));
            foreach (System.ServiceModel.Description.ServiceEndpoint endpoint in host.Description.Endpoints)
            {
                Console.WriteLine(string.Format("   {0}", endpoint.Address));
            }
        }

        public static void ServiceStop(System.ServiceModel.ServiceHost host)
        {
            Console.WriteLine(string.Format("服务停止：{0}", host.Description.Name));
        }
    }
}
