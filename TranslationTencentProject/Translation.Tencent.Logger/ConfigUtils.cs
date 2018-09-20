using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation.Tencent.Logger
{
    public static class ConfigUtils
    {
        public static T GetSection<T>(string elementName) where T : ConfigurationElement
        {
            if (elementName == null)
            {
                throw new ArgumentNullException("elementName");
            }
            T t = (T)ConfigurationManager.GetSection(elementName);
            if (t == null)
            {
                throw new ConfigurationErrorsException("未找到指定配置节元素 '" + elementName + "'。");
            }
            return t;
        }
    }
}
