using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FourteenContract
{
    [ServiceContract]
    public interface IFirstService
    {
        [OperationContract]
        string GetData();
    }
}
