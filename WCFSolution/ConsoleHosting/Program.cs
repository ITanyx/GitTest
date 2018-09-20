using CalculateWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculateService), new Uri("http://192.168.0.104:9099/CalculateWcfService")))
            {
                BasicHttpBinding bind = new BasicHttpBinding
                {
                    Name = "basichttpbinding"
                };
                host.AddServiceEndpoint(typeof(ICalculateService), bind, "CalculateWcfService");
                if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior()
                    {
                        HttpGetEnabled = true
                    };
                    host.Description.Behaviors.Add(behavior);
                }
                host.AddServiceEndpoint(typeof(IMetadataExchange), bind, "mex");
                host.Opened += (o, e) =>
                {
                    Console.WriteLine("服务已启动");
                };
                if (host.State != CommunicationState.Opened)
                {
                    host.Open();
                }

                Console.Read();
            }
        }
    }
}
