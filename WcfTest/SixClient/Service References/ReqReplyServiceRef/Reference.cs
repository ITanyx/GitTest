﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SixClient.ReqReplyServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReqReplyServiceRef.IReqReply")]
    public interface IReqReply {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReqReply/SayHello", ReplyAction="http://tempuri.org/IReqReply/SayHelloResponse")]
        string SayHello(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReqReply/SayHello", ReplyAction="http://tempuri.org/IReqReply/SayHelloResponse")]
        System.Threading.Tasks.Task<string> SayHelloAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReqReplyChannel : SixClient.ReqReplyServiceRef.IReqReply, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReqReplyClient : System.ServiceModel.ClientBase<SixClient.ReqReplyServiceRef.IReqReply>, SixClient.ReqReplyServiceRef.IReqReply {
        
        public ReqReplyClient() {
        }
        
        public ReqReplyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReqReplyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReqReplyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReqReplyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHello(string name) {
            return base.Channel.SayHello(name);
        }
        
        public System.Threading.Tasks.Task<string> SayHelloAsync(string name) {
            return base.Channel.SayHelloAsync(name);
        }
    }
}
