using NineService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AppHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost MessageHost = null;
            ServiceHost CalculatorHost = null;
            try
            {
                MessageHost = new ServiceHost(typeof(ServiceMessage));
                CalculatorHost = new ServiceHost(typeof(ServiceCalculator));

                MessageHost.Open();
                CalculatorHost.Open();
                Console.WriteLine("服务已经启动。。。");
                Console.ReadLine();
                MessageHost.Close();
                CalculatorHost.Close();
            }
            catch (Exception ex)
            {
                if (MessageHost != null)
                {
                    MessageHost.Abort();
                }

                if (CalculatorHost != null)
                {
                    CalculatorHost.Abort();
                }

                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}
