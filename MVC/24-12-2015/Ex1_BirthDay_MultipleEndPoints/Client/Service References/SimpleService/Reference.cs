﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.SimpleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SimpleService.IBirthService")]
    public interface IBirthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBirthService/GetAge", ReplyAction="http://tempuri.org/IBirthService/GetAgeResponse")]
        int GetAge(System.DateTime birthDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBirthService/GetAge", ReplyAction="http://tempuri.org/IBirthService/GetAgeResponse")]
        System.Threading.Tasks.Task<int> GetAgeAsync(System.DateTime birthDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBirthService/GetDifference", ReplyAction="http://tempuri.org/IBirthService/GetDifferenceResponse")]
        int GetDifference(System.DateTime first, System.DateTime second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBirthService/GetDifference", ReplyAction="http://tempuri.org/IBirthService/GetDifferenceResponse")]
        System.Threading.Tasks.Task<int> GetDifferenceAsync(System.DateTime first, System.DateTime second);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBirthServiceChannel : Client.SimpleService.IBirthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BirthServiceClient : System.ServiceModel.ClientBase<Client.SimpleService.IBirthService>, Client.SimpleService.IBirthService {
        
        public BirthServiceClient() {
        }
        
        public BirthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BirthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BirthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BirthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetAge(System.DateTime birthDate) {
            return base.Channel.GetAge(birthDate);
        }
        
        public System.Threading.Tasks.Task<int> GetAgeAsync(System.DateTime birthDate) {
            return base.Channel.GetAgeAsync(birthDate);
        }
        
        public int GetDifference(System.DateTime first, System.DateTime second) {
            return base.Channel.GetDifference(first, second);
        }
        
        public System.Threading.Tasks.Task<int> GetDifferenceAsync(System.DateTime first, System.DateTime second) {
            return base.Channel.GetDifferenceAsync(first, second);
        }
    }
}
