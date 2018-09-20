using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;

namespace TencentWCF
{
    public static class WCFConfigProvider
    {
        private static Configuration _config;
        private static Dictionary<string, Assembly> _serviceAssemblies;
        private static Dictionary<string, Assembly> _contractAssemblies;
        private static Dictionary<string, WCFServiceConfig> _serviceConfigs;
        private static Dictionary<string, WCFServiceConfig> _clientConfigs;
        private static WCFServiceConfigSection _wcfServiceConfigSection;
        private static ServiceModelSectionGroup _serviceModel;
        private static object _locker;
        public static WCFServiceConfigSection ServiceConfigSection
        {
            get
            {
                WCFConfigProvider.InitServiceConfigSection();
                return WCFConfigProvider._wcfServiceConfigSection;
            }
        }
        public static List<WCFServiceConfig> ServiceConfigs
        {
            get
            {
                WCFConfigProvider.InitServiceConfigs();
                return WCFConfigProvider._serviceConfigs.Values.ToList<WCFServiceConfig>();
            }
        }
        public static List<WCFServiceConfig> ClientConfigs
        {
            get
            {
                WCFConfigProvider.InitClientConfigs();
                return WCFConfigProvider._clientConfigs.Values.ToList<WCFServiceConfig>();
            }
        }
        public static List<Assembly> ServiceAssemblies
        {
            get
            {
                if (WCFConfigProvider._serviceAssemblies == null)
                {
                    lock (WCFConfigProvider._locker)
                    {
                        if (WCFConfigProvider._serviceAssemblies == null)
                        {
                            Dictionary<string, Assembly> dictionary = new Dictionary<string, Assembly>();
                            foreach (WCFServiceConfig wCFServiceConfig in WCFConfigProvider.ServiceConfigSection.Services)
                            {
                                dictionary.Add(wCFServiceConfig.Key, Assembly.Load(wCFServiceConfig.Assembly));
                            }
                            WCFConfigProvider._serviceAssemblies = dictionary;
                        }
                    }
                }
                return WCFConfigProvider._serviceAssemblies.Values.ToList<Assembly>();
            }
        }
        public static List<Assembly> ContractAssemblies
        {
            get
            {
                if (WCFConfigProvider._contractAssemblies == null)
                {
                    lock (WCFConfigProvider._locker)
                    {
                        if (WCFConfigProvider._contractAssemblies == null)
                        {
                            Dictionary<string, Assembly> dictionary = new Dictionary<string, Assembly>();
                            foreach (WCFServiceConfig wCFServiceConfig in WCFConfigProvider.ServiceConfigSection.Services)
                            {
                                dictionary.Add(wCFServiceConfig.Key, Assembly.Load(wCFServiceConfig.Assembly));
                            }
                            WCFConfigProvider._contractAssemblies = dictionary;
                        }
                    }
                }
                return WCFConfigProvider._contractAssemblies.Values.ToList<Assembly>();
            }
        }
        static WCFConfigProvider()
        {
            WCFConfigProvider._serviceAssemblies = null;
            WCFConfigProvider._contractAssemblies = null;
            WCFConfigProvider._serviceConfigs = null;
            WCFConfigProvider._clientConfigs = null;
            WCFConfigProvider._wcfServiceConfigSection = null;
            WCFConfigProvider._serviceModel = null;
            WCFConfigProvider._locker = new object();
            if (Path.GetFileName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile).Equals("web.config", StringComparison.CurrentCultureIgnoreCase))
            {
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
                };
                WCFConfigProvider._config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                return;
            }
            WCFConfigProvider._config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        private static void InitServiceConfigSection()
        {
            if (WCFConfigProvider._wcfServiceConfigSection == null)
            {
                lock (WCFConfigProvider._locker)
                {
                    if (WCFConfigProvider._wcfServiceConfigSection == null)
                    {
                        if (WCFConfigProvider._config == null)
                        {
                            throw new ConfigurationErrorsException("配置文件错误!");
                        }
                        
                        WCFConfigProvider._wcfServiceConfigSection = (WCFConfigProvider._config.Sections["FAF.wcfServices"] as WCFServiceConfigSection);
                        if (WCFConfigProvider._wcfServiceConfigSection == null)
                        {
                            throw new ConfigurationErrorsException("FAF.wcfServices配置文错误!");
                        }
                    }
                }
            }
        }
        private static void InitServiceConfigs()
        {
            if (WCFConfigProvider._serviceConfigs == null)
            {
                lock (WCFConfigProvider._locker)
                {
                    if (WCFConfigProvider._serviceConfigs == null)
                    {
                        Dictionary<string, WCFServiceConfig> dictionary = new Dictionary<string, WCFServiceConfig>();
                        foreach (WCFServiceConfig wCFServiceConfig in WCFConfigProvider.ServiceConfigSection.Services)
                        {
                            dictionary.Add(wCFServiceConfig.Key, wCFServiceConfig);
                        }
                        WCFConfigProvider._serviceConfigs = dictionary;
                    }
                }
            }
        }
        private static void InitClientConfigs()
        {
            if (WCFConfigProvider._clientConfigs == null)
            {
                lock (WCFConfigProvider._locker)
                {
                    if (WCFConfigProvider._clientConfigs == null)
                    {
                        Dictionary<string, WCFServiceConfig> dictionary = new Dictionary<string, WCFServiceConfig>();
                        foreach (WCFServiceConfig wCFServiceConfig in WCFConfigProvider.ServiceConfigSection.Clients)
                        {
                            dictionary.Add(wCFServiceConfig.Key, wCFServiceConfig);
                        }
                        WCFConfigProvider._clientConfigs = dictionary;
                    }
                }
            }
        }
        public static string GetBaseAddressByServiceType(Type serviceType, string key = "")
        {
            WCFConfigProvider.InitServiceConfigs();
            WCFServiceConfig wCFServiceConfig;
            if (!string.IsNullOrEmpty(key))
            {
                if (WCFConfigProvider._serviceConfigs.TryGetValue(key, out wCFServiceConfig))
                {
                    throw new Exception(string.Format("key:{0} is not exists in wcfservice config.", key));
                }
            }
            else
            {
                wCFServiceConfig = (
                    from p in WCFConfigProvider._serviceConfigs.Values
                    where p.Assembly == serviceType.Assembly.GetName().Name
                    select p).FirstOrDefault<WCFServiceConfig>();
            }
            if (wCFServiceConfig != null)
            {
                return Path.Combine(wCFServiceConfig.BaseAddress, wCFServiceConfig.Key);
            }
            return null;
        }
        public static string GetBaseAddressByContractType(Type contractType, string key = "")
        {
            WCFConfigProvider.InitClientConfigs();
            WCFServiceConfig wCFServiceConfig;
            if (!string.IsNullOrEmpty(key))
            {
                if (WCFConfigProvider._clientConfigs.TryGetValue(key, out wCFServiceConfig))
                {
                    throw new Exception(string.Format("key:{0} is not exists in wcfservice config.", key));
                }
            }
            else
            {
                wCFServiceConfig = (
                    from p in WCFConfigProvider._clientConfigs.Values
                    where p.Assembly == contractType.Assembly.GetName().Name
                    select p).FirstOrDefault<WCFServiceConfig>();
            }
            if (wCFServiceConfig != null)
            {
                return Path.Combine(wCFServiceConfig.BaseAddress, wCFServiceConfig.Key);
            }
            return null;
        }
        public static Binding GetDefaultBinding(string scheme)
        {
            WCFConfigProvider.InitServiceModel();
            if (WCFConfigProvider._serviceModel == null)
            {
                return null;
            }
            ProtocolMappingElement protocolMappingElement = WCFConfigProvider._serviceModel.ProtocolMapping.ProtocolMappingCollection[scheme];
            if (protocolMappingElement != null)
            {
                string binding = protocolMappingElement.Binding;
                string bindingConfiguration = protocolMappingElement.BindingConfiguration;
                string a;
                if ((a = binding.ToLower()) != null)
                {
                    if (a == "nettcpbinding")
                    {
                        return new NetTcpBinding(bindingConfiguration);
                    }
                    if (a == "basichttpbinding")
                    {
                        return new BasicHttpBinding(bindingConfiguration);
                    }
                    if (a == "wshttpbinding")
                    {
                        return new WSHttpBinding(bindingConfiguration);
                    }
                }
            }
            return null;
        }
        public static List<IEndpointBehavior> GetDefaultEndPointBehaviors(string scheme)
        {
            List<IEndpointBehavior> list = new List<IEndpointBehavior>();
            WCFConfigProvider.InitServiceModel();
            if (WCFConfigProvider._serviceModel == null)
            {
                return list;
            }
            string defaultEndPointBehaviorName = WCFConfigProvider.GetDefaultEndPointBehaviorName(scheme);
            if (WCFConfigProvider._serviceModel.Behaviors.EndpointBehaviors.ContainsKey(defaultEndPointBehaviorName))
            {
                EndpointBehaviorElement endpointBehaviorElement = WCFConfigProvider._serviceModel.Behaviors.EndpointBehaviors[defaultEndPointBehaviorName];
                foreach (BehaviorExtensionElement current in endpointBehaviorElement)
                {
                    IEndpointBehavior endpointBehavior = WCFConfigProvider.CreateBehavior<IEndpointBehavior>(current);
                    if (endpointBehavior != null)
                    {
                        list.Add(endpointBehavior);
                    }
                }
            }
            return list;
        }
        private static string GetDefaultEndPointBehaviorName(string scheme)
        {
            ProtocolMappingElement protocolMappingElement = WCFConfigProvider._serviceModel.ProtocolMapping.ProtocolMappingCollection[scheme];
            if (protocolMappingElement != null)
            {
                string binding = protocolMappingElement.Binding;
                string arg_26_0 = protocolMappingElement.BindingConfiguration;
                string a;
                if ((a = binding.ToLower()) != null)
                {
                    if (a == "nettcpbinding")
                    {
                        return "defaultNetTcpEndPointBehavior";
                    }
                    if (a == "basichttpbinding")
                    {
                        return "defaulBasicHttpEndPointBehavior";
                    }
                    if (a == "wshttpbinding")
                    {
                        return "defaultWSHttpEndPointBehavior";
                    }
                    if (a == "webhttpbinding")
                    {
                        return "defaultWebHttpEndPointBehavior";
                    }
                }
            }
            return string.Empty;
        }
        public static List<IServiceBehavior> GetDefaultSeviceBehaviors(string scheme)
        {
            List<IServiceBehavior> list = new List<IServiceBehavior>();
            WCFConfigProvider.InitServiceModel();
            if (WCFConfigProvider._serviceModel == null)
            {
                return list;
            }
            string defaultServiceBehaviorName = WCFConfigProvider.GetDefaultServiceBehaviorName(scheme);
            if (WCFConfigProvider._serviceModel.Behaviors.ServiceBehaviors.ContainsKey(defaultServiceBehaviorName))
            {
                ServiceBehaviorElement serviceBehaviorElement = WCFConfigProvider._serviceModel.Behaviors.ServiceBehaviors[defaultServiceBehaviorName];
                foreach (BehaviorExtensionElement current in serviceBehaviorElement)
                {
                    IServiceBehavior serviceBehavior = WCFConfigProvider.CreateBehavior<IServiceBehavior>(current);
                    if (serviceBehavior != null)
                    {
                        list.Add(serviceBehavior);
                    }
                }
            }
            return list;
        }
        private static string GetDefaultServiceBehaviorName(string scheme)
        {
            ProtocolMappingElement protocolMappingElement = WCFConfigProvider._serviceModel.ProtocolMapping.ProtocolMappingCollection[scheme];
            if (protocolMappingElement != null)
            {
                string binding = protocolMappingElement.Binding;
                string arg_26_0 = protocolMappingElement.BindingConfiguration;
                string a;
                if ((a = binding.ToLower()) != null)
                {
                    if (a == "nettcpbinding")
                    {
                        return "defaultNetTcpServiceBehavior";
                    }
                    if (a == "basichttpbinding")
                    {
                        return "defaulBasicHttpServiceBehavior";
                    }
                    if (a == "wshttpbinding")
                    {
                        return "defaultWSHttpServiceBehavior";
                    }
                    if (a == "webhttpbinding")
                    {
                        return "defaultWebHttpServiceBehavior";
                    }
                }
            }
            return string.Empty;
        }
        private static void InitServiceModel()
        {
            if (WCFConfigProvider._serviceModel == null)
            {
                lock (WCFConfigProvider._locker)
                {
                    if (WCFConfigProvider._serviceModel == null)
                    {
                        ConfigurationSectionGroup configurationSectionGroup = WCFConfigProvider._config.SectionGroups["system.serviceModel"];
                        WCFConfigProvider._serviceModel = (configurationSectionGroup as ServiceModelSectionGroup);
                    }
                }
            }
        }
        private static T CreateBehavior<T>(BehaviorExtensionElement behaviorElement)
        {
            MethodInfo method = behaviorElement.GetType().GetMethod("CreateBehavior", BindingFlags.Instance | BindingFlags.NonPublic);
            if (method != null)
            {
                return (T)method.Invoke(behaviorElement, null);
            }
            return default(T);
        }
    }
}
