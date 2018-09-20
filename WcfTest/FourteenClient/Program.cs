using FourteenContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using TencentWCF;

namespace FourteenClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = TencentWCF.WCFClientProxy.Current.Call<IFirstService, string>(p => p.GetData());

            Console.WriteLine(result);


            //Binding defaultBinding = WCFConfigProvider.GetDefaultBinding("http");
            //ContractDescription contract = ContractDescription.GetContract(typeof(IFirstService));
            //ServiceEndpoint serviceEndpoint = new ServiceEndpoint(contract, defaultBinding, new EndpointAddress("http://localhost:8093/TravelPlanningPlatform/FourteenContract.IFirstService"));

            //ChannelFactory<IFirstService> chanFactory = new ChannelFactory<IFirstService>(serviceEndpoint);
            //var tChannel = chanFactory.CreateChannel();

            //((IClientChannel)tChannel).Open();
            //string result = tChannel.GetData();
            //((IClientChannel)tChannel).Close();

            //Console.WriteLine(result);

            Console.Read();
        }
    }
}
