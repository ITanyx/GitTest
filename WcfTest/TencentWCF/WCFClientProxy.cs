using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TencentWCF
{
    public class WCFClientProxy : IWCFClientProxy
    {
        private static WCFClientProxy _current = new WCFClientProxy();
        public static WCFClientProxy Current
        {
            get
            {
                return WCFClientProxy._current;
            }
        }
        public TReturn Call<TChannel, TReturn>(Func<TChannel, TReturn> fun)
        {
            ChannelFactory<TChannel> chanFactory = ChannelFactoryProvider.Current.Create<TChannel>();
            return this.CallChannel<TChannel, TReturn>(fun, chanFactory);
        }
        public void Call<TChannel>(Action<TChannel> action)
        {
            ChannelFactory<TChannel> chanFactory = ChannelFactoryProvider.Current.Create<TChannel>();
            this.CallChannel<TChannel>(action, chanFactory);
        }
        public void Call<TChannel>(Action<TChannel> action, string endpointConfigurationName)
        {
            ChannelFactory<TChannel> chanFactory = ChannelFactoryProvider.Current.Create<TChannel>(endpointConfigurationName);
            this.CallChannel<TChannel>(action, chanFactory);
        }
        public TReturn Call<TChannel, TReturn>(Func<TChannel, TReturn> fun, string endpointConfigurationName)
        {
            ChannelFactory<TChannel> chanFactory = ChannelFactoryProvider.Current.Create<TChannel>(endpointConfigurationName);
            return this.CallChannel<TChannel, TReturn>(fun, chanFactory);
        }
        private void CallChannel<TChannel>(Action<TChannel> action, ChannelFactory<TChannel> chanFactory)
        {
            TChannel tChannel = chanFactory.CreateChannel();
            try
            {
                ((IClientChannel)tChannel).Open();
                action(tChannel);
            }
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                ((IClientChannel)tChannel).Close();
            }
        }
        private TReturn CallChannel<TChannel, TReturn>(Func<TChannel, TReturn> func, ChannelFactory<TChannel> chanFactory)
        {
            TChannel tChannel = chanFactory.CreateChannel();
            TReturn result;
            try
            {
                ((IClientChannel)tChannel).Open();
                TReturn tReturn = func(tChannel);
                result = tReturn;
            }
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }
            finally
            {
                ((IClientChannel)tChannel).Close();
            }
            return result;
        }
    }
}
