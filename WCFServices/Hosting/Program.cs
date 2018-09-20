using Contracts;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (ServiceHost host = new ServiceHost(typeof(CalculatorService), new Uri("http://127.0.0.1:9999/CalculatorService")))
            //{
            //    host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");
            //    if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
            //    {
            //        ServiceMetadataBehavior behavior = new ServiceMetadataBehavior()
            //        {
            //            HttpGetEnabled = true
            //        };
            //        host.Description.Behaviors.Add(behavior);
            //    }
            //    host.Opened += (o, e) =>
            //    {
            //        Console.WriteLine("服务已启动");
            //    };
            //    if (host.State != CommunicationState.Opened)
            //    {
            //        host.Open();
            //    }

            //    Console.Read();
            //}

            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Open();
                Console.WriteLine("服务已启动");
                Console.Read();
            }
        }
    }
}
