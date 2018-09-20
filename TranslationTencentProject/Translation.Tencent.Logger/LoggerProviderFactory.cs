using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation.Tencent.Logger
{
    public static class LoggerProviderFactory
    {
        private static LoggerProviderSection _configSection = ConfigUtils.GetSection<LoggerProviderSection>("LoggerProvider");
        private static ILoggerProvider CreateLoggerProvider(string providerName)
        {
            return Activator.CreateInstance(LoggerProviderFactory._configSection.LoggerProviders.GetElement(providerName).ProviderType, new object[]
            {
                LoggerProviderFactory._configSection.LoggerProviders.GetElement(providerName)
            }) as ILoggerProvider;
        }
        public static ILoggerProvider GetLoggerProvider()
        {
            return LoggerProviderFactory.GetLoggerProvider(LoggerProviderFactory._configSection.DefaultProviderName);
        }
        public static ILoggerProvider GetLoggerProvider(string providerName)
        {
            if (string.IsNullOrEmpty(providerName))
            {
                throw new ArgumentNullException("Error!");
            }
            return LoggerProviderFactory.CreateLoggerProvider(providerName);
        }
    }
}
