using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentWCF
{
    public class WCFServiceConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("service"), ConfigurationCollection(typeof(WCFServiceConfigCollection))]
        public WCFServiceConfigCollection Services
        {
            get
            {
                return base["service"] as WCFServiceConfigCollection;
            }
            set
            {
                base["service"] = value;
            }
        }
        [ConfigurationProperty("client"), ConfigurationCollection(typeof(WCFServiceConfigCollection))]
        public WCFServiceConfigCollection Clients
        {
            get
            {
                return base["client"] as WCFServiceConfigCollection;
            }
            set
            {
                base["client"] = value;
            }
        }
    }
}
