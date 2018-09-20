using CalculateWcfService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceHosting
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private ServiceHost host = null;
        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(CalculateService), new Uri("http://192.168.0.104:9099/CalculateWcfService"));
            BasicHttpBinding bind = new BasicHttpBinding
            {
                Name = "basichttpbinding"
            };
            host.AddServiceEndpoint(typeof(ICalculateService), bind, "CalculateWcfService");
            if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
            {
                ServiceMetadataBehavior behavior = new ServiceMetadataBehavior()
                {
                    HttpGetEnabled = true
                };
                host.Description.Behaviors.Add(behavior);
            }
            host.AddServiceEndpoint(typeof(IMetadataExchange), bind, "mex");
            if (host.State != CommunicationState.Opened)
            {
                host.Open();
            }
        }

        protected override void OnStop()
        {
            if (host != null)
            {
                host.Close();
            }
        }
    }
}
