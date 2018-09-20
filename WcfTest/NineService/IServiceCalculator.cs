using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NineService
{
    [ServiceContract]
    public interface IServiceCalculator
    {
        [OperationContract]
        double Add(double n1, double n2);
    }
}
