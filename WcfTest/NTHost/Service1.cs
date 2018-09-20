using NineService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace NTHost
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        ServiceHost MessageHost = null;
        ServiceHost CalculatorHost = null;
        protected override void OnStart(string[] args)
        {
            try
            {
                MessageHost = new ServiceHost(typeof(ServiceMessage));
                CalculatorHost = new ServiceHost(typeof(ServiceCalculator));

                MessageHost.Open();
                CalculatorHost.Open();
            }
            catch (Exception)
            {
                if (MessageHost != null)
                {
                    MessageHost.Abort();
                }
                if (CalculatorHost != null)
                {
                    CalculatorHost.Abort();
                }
            }
        }

        protected override void OnStop()
        {
            try
            {
                MessageHost.Close();
                CalculatorHost.Close();
            }
            catch (Exception)
            {
                if (MessageHost != null)
                {
                    MessageHost.Abort();
                }
                if (CalculatorHost != null)
                {
                    CalculatorHost.Abort();
                }
            }
        }
    }
}
