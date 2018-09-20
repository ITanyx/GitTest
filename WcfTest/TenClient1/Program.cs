using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenClient1.UserInfoServiceRef;

namespace TenClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfoClient proxy = null;
            try
            {
                proxy = new UserInfoClient();
                User[] Users = proxy.GetInfo(null);
                Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", "ID", "Name", "Age", "Nationality");
                for (int i = 0; i < Users.Length; i++)
                {
                    Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}",
                      Users[i].ID.ToString(),
                      Users[i].Name.ToString(),
                      Users[i].Age.ToString(),
                      Users[i].Nationality.ToString());
                }
                proxy.Close();

                Console.Read();
            }
            catch (Exception)
            {
                if (proxy != null)
                {
                    proxy.Abort();
                }
            }
        }
    }
}
