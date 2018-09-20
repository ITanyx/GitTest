using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            String key = "";
            while (String.Compare(key, "Q", true) != 0)
            {
                FirstServiceClient client = new FirstServiceClient();
                Console.WriteLine(client.GetData(key));
                key = Console.ReadLine();
            }
        }
    }
}
