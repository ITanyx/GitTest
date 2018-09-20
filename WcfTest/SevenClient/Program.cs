using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiceClient Service1 = null;
            ServiceReference2.ServiceClient Service2 = null;
            
            try
            {
                Console.WriteLine("****************SayHello请求响应通讯服务示例*******************");
                Service1 = new ServiceReference1.ServiceClient();
                Console.WriteLine(Service1.GetMessage());
                Service1.Close();

                Service2 = new ServiceReference2.ServiceClient();
                Console.WriteLine(Service2.GetMessage());
                Service2.Close();
            }
            catch (Exception ex)
            {
                if (Service1 != null)
                {
                    Service1.Abort();
                }

                if (Service2 != null)
                {
                    Service2.Abort();
                }
            }

            Console.Read();
        }
    }
}
