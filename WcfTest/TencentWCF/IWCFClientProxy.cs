using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentWCF
{
    public interface IWCFClientProxy
    {
        void Call<TContract>(Action<TContract> action);
        TResult Call<TContract, TResult>(Func<TContract, TResult> func);
        void Call<TChannel>(Action<TChannel> action, string endpointConfigurationName);
        TReturn Call<TChannel, TReturn>(Func<TChannel, TReturn> fun, string endpointConfigurationName);
    }
}
