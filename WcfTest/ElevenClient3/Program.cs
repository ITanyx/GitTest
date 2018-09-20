using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ElevenClient3
{
    class Program
    {
        static void Main(string[] args)
        {
            EndpointAddress address = new EndpointAddress("http://localhost:1234/UserInfo");
            WSHttpBinding binding = new WSHttpBinding();
            ChannelFactory<IUserInfo> factory = new ChannelFactory<IUserInfo>(binding, address);
            IUserInfo channel = factory.CreateChannel();
            IAsyncResult ar = channel.BeginGetInfo(null, GetInfoCallback, channel);
            Console.WriteLine("此字符串在调用方法前输出，说明异步调用成功！");

            Console.Read();
        }

        static void GetInfoCallback(IAsyncResult ar)
        {
            IUserInfo m_service = ar.AsyncState as IUserInfo;
            ElevenService.User[] Users = m_service.EndGetInfo(ar);

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
