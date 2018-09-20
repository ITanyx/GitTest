using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FourService
{
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        string Show(string name);
    }
}
