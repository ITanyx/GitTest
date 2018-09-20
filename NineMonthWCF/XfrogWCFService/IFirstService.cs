using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace XfrogWCFService
{
    [ServiceContract]
    public interface IFirstService
    {
        [OperationContract]
        String GetData(String name);
    }
}
