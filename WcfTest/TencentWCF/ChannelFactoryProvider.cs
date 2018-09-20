using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TencentCommon;

namespace TencentWCF
{
    public class ChannelFactoryProvider : KVCache<string, IChannelFactory>
    {
        public static ChannelFactoryProvider Current
        {
            get;
            private set;
        }
        static ChannelFactoryProvider()
        {
            ChannelFactoryProvider.Current = new ChannelFactoryProvider();
        }
        private string ConstructKey(string typeName, string configKey = "")
        {
            return string.Format("{0}_{1}", configKey, typeName);
        }
        public ChannelFactory<T> Create<T>()
        {
            Type tp = typeof(T);
            string key = this.ConstructKey(tp.FullName, string.Empty);
            return base.TryCreateCacheItem(key, () => this.Create<T>(tp, "", null)) as ChannelFactory<T>;
        }
        public ChannelFactory<T> Create<T>(string configKey)
        {
            Type tp = typeof(T);
            string key = this.ConstructKey(tp.FullName, configKey);
            return base.TryCreateCacheItem(key, () => this.Create<T>(tp, configKey, null)) as ChannelFactory<T>;
        }

        private ChannelFactory<T> Create<T>(Type contractType, string configKey, Uri uri = null)
        {
            if (uri == null)
            {
                string baseAddressByContractType = WCFConfigProvider.GetBaseAddressByContractType(contractType, configKey);
                uri = new Uri(Path.Combine(baseAddressByContractType, contractType.FullName));
            }
            Binding defaultBinding = WCFConfigProvider.GetDefaultBinding(uri.Scheme);
            ContractDescription contract = ContractDescription.GetContract(contractType);
            ServiceEndpoint serviceEndpoint = new ServiceEndpoint(contract, defaultBinding, new EndpointAddress(uri.OriginalString));
            WCFConfigProvider.GetDefaultEndPointBehaviors(uri.Scheme).ForEach(delegate (IEndpointBehavior behavior)
            {
                if (serviceEndpoint.Behaviors.Contains(behavior.GetType()))
                {
                    serviceEndpoint.Behaviors.Remove(behavior.GetType());
                }
                serviceEndpoint.Behaviors.Add(behavior);
            }
            );
            return new ChannelFactory<T>(serviceEndpoint);
        }
    }
}
