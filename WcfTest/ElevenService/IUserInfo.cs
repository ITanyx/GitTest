using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ElevenService
{
    [ServiceContract]
    public interface IUserInfo
    {
        [OperationContract]
        User[] GetInfo(int? id = null);
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Nationality { get; set; }
    }
}
