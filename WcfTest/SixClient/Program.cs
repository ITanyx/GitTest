using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixClient.ReqReplyServiceRef;

namespace SixClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ReqReplyClient proxy = null;
            try
            {
                proxy = new ReqReplyClient();
                Console.WriteLine(proxy.SayHello("WCF"));
                proxy.Close();
            }
            catch (Exception)
            {
                if (proxy != null)
                {
                    proxy.Abort();
                }
            }
            Console.Read();
        }
    }
}
