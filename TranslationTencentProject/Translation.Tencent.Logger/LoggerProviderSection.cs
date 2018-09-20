using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Translation.Tencent.Logger
{
    [AspNetHostingPermission(SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal)]
    public sealed class LoggerProviderSection : ConfigurationSection
    {
        [ConfigurationCollection(typeof(LoggerProviderElementCollection)), ConfigurationProperty("providers")]
        public LoggerProviderElementCollection LoggerProviders
        {
            get
            {
                return base["providers"] as LoggerProviderElementCollection;
            }
            set
            {
                base["providers"] = value;
            }
        }
        [ConfigurationProperty("defaultProvider", IsRequired = true)]
        public string DefaultProviderName
        {
            get
            {
                return (string)base["defaultProvider"];
            }
            set
            {
                base["defaultProvider"] = value;
            }
        }
    }
}
