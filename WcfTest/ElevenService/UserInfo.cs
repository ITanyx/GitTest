using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElevenService
{
    public class UserInfo : IUserInfo
    {
        public User[] GetInfo(int? id = null)
        {
            Thread.Sleep(1000);

            List<User> Users = new List<User>();
            Users.Add(new User { ID = 1, Name = "JACK", Age = 20, Nationality = "CHINA" });
            Users.Add(new User { ID = 2, Name = "TOM", Age = 18, Nationality = "JAPAN" });
            Users.Add(new User { ID = 3, Name = "SMITH", Age = 22, Nationality = "KOREA" });
            Users.Add(new User { ID = 4, Name = "ALENCE", Age = 21, Nationality = "INDIA" });
            Users.Add(new User { ID = 5, Name = "JOHN", Age = 22, Nationality = "SINGAPORE" });

            if (id != null)
            {
                return Users.Where(x => x.ID == id).ToArray();
            }
            else
            {
                return Users.ToArray();
            }
        }
    }
}
