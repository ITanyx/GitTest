using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SixService
{
    [ServiceContract]
    public interface IReqReply
    {
        [OperationContract]
        string SayHello(string name);
    }
}
