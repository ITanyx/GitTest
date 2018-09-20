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
    [ConfigurationCollection(typeof(LoggerProviderElement), CollectionType = ConfigurationElementCollectionType.BasicMap)]
    [AspNetHostingPermission(SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal)]
    public class LoggerProviderElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new LoggerProviderElement();
        }
        public LoggerProviderElement GetElement(string providerName)
        {
            if (string.IsNullOrEmpty(providerName))
            {
                throw new ArgumentNullException("providerName");
            }
            return (LoggerProviderElement)base.BaseGet(providerName);
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((LoggerProviderElement)element).ProviderName;
        }
    }
}
