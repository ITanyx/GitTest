using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation.Tencent.Logger
{
    public class LoggerProviderElement : ConfigurationElement
    {
        private const string _namePropertyName = "name";
        private const string _typePropertyName = "type";
        private ConfigurationConverter typeConverter = new ConfigurationConverter();
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string ProviderName
        {
            get
            {
                return (string)base["name"];
            }
            set
            {
                base["name"] = value;
            }
        }
        public Type ProviderType
        {
            get
            {
                return (Type)this.typeConverter.ConvertFrom(this.ProviderTypeName);
            }
            set
            {
                this.ProviderTypeName = this.typeConverter.ConvertToString(value);
            }
        }
        [ConfigurationProperty("type", IsRequired = true)]
        public string ProviderTypeName
        {
            get
            {
                return (string)base["type"];
            }
            set
            {
                base["type"] = value;
            }
        }
        [ConfigurationProperty("cfgFile")]
        public string ConfigFile
        {
            get
            {
                return (string)base["cfgFile"];
            }
            set
            {
                base["cfgFile"] = value;
            }
        }
        [ConfigurationProperty("logPath")]
        public string LogPath
        {
            get
            {
                return (string)base["logPath"];
            }
            set
            {
                base["logPath"] = value;
            }
        }
    }
}
