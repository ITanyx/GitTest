using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentWCF
{
    public class WCFServiceConfig : ConfigurationElement
    {
        [ConfigurationProperty("key", IsRequired = true, IsKey = true)]
        public string Key
        {
            get
            {
                return (string)base["key"];
            }
            set
            {
                base["key"] = value;
            }
        }
        [ConfigurationProperty("assembly", IsRequired = true)]
        public string Assembly
        {
            get
            {
                return (string)base["assembly"];
            }
            set
            {
                base["assembly"] = value;
            }
        }
        [ConfigurationProperty("baseAddress", IsRequired = true)]
        public string BaseAddress
        {
            get
            {
                return (string)base["baseAddress"];
            }
            set
            {
                base["baseAddress"] = value;
            }
        }
    }
}
