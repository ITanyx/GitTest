using SevenService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SevenHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host1 = null;
            ServiceHost host2 = null;
            try
            {
                host1 = new ServiceHost(typeof(Service1));
                host1.Opened += (o, s) => Console.WriteLine("Server1 Opened!");
                host1.Open();

                host2 = new ServiceHost(typeof(Service2));
                host2.Opened += (o, s) => Console.WriteLine("Server2 Opened!");
                host2.Open();

            }
            catch (Exception ex)
            {
                if (host1 != null)
                {
                    host1.Abort();
                }

                if (host2 != null)
                {
                    host2.Abort();
                }
            }
            Console.Read();
        }
    }
}
