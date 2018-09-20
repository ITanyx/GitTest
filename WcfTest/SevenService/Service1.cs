using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SevenService
{
    public class Service1 : IService
    {
        public string GetMessage()
        {
            var address = OperationContext.Current.Channel.LocalAddress.ToString();
            return string.Format("From Server1: Hello Client at [{0}]", address);
        }
    }
}
