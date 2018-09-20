using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using TenService;

namespace TenClient3
{
    class Program
    {
        static void Main(string[] args)
        {
            EndpointAddress address = new EndpointAddress("http://localhost:1234/UserInfo");
            WSHttpBinding binding = new WSHttpBinding();
            ChannelFactory<IUserInfo> factory = new ChannelFactory<IUserInfo>(binding, address);
            IUserInfo channel = factory.CreateChannel();


            User[] Users = channel.GetInfo(null);
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", "ID", "Name", "Age", "Nationality");
            for (int i = 0; i < Users.Length; i++)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}",
                  Users[i].ID.ToString(),
                  Users[i].Name.ToString(),
                  Users[i].Age.ToString(),
                  Users[i].Nationality.ToString());
            }

            ((IChannel)channel).Close();
            factory.Close();
            Console.Read();
        }
    }
}
