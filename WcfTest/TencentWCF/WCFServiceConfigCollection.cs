using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentWCF
{
    public class WCFServiceConfigCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new WCFServiceConfig();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((WCFServiceConfig)element).Key;
        }
    }
}
