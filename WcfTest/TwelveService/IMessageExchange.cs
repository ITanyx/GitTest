using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TwelveService
{
    //[ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IMessageExchangeCallback))]
    [ServiceContract(CallbackContract = typeof(IMessageExchangeCallback))]
    public interface IMessageExchange
    {
        [OperationContract(IsOneWay = true)]
        void Send(string message);
    }

    public interface IMessageExchangeCallback
    {
        [OperationContract(IsOneWay = true)]
        void Receive(string message);
    }
}
