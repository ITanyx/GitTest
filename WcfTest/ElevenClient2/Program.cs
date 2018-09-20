using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfoClient proxy = new UserInfoClient();
            proxy.GetInfoCompleted += new EventHandler<GetInfoCompletedEventArgs>(proxy_GetInfoCompleted);
            proxy.GetInfoAsync(null);
            Console.WriteLine("此字符串在调用方法前输出，说明异步调用成功！");
            Console.Read();
        }

        static void proxy_GetInfoCompleted(object sender, GetInfoCompletedEventArgs e)
        {
            ElevenService.User[] Users = e.Result.ToArray();
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", "ID", "Name", "Age", "Nationality");
            for (int i = 0; i < Users.Length; i++)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}",
                  Users[i].ID.ToString(),
                  Users[i].Name.ToString(),
                  Users[i].Age.ToString(),
                  Users[i].Nationality.ToString());
            }
        }
    }
}
