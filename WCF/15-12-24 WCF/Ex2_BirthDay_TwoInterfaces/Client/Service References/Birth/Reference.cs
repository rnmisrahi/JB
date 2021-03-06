﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Birth {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Birth.ISimpleBirthService")]
    public interface ISimpleBirthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleBirthService/GetAgeSimple", ReplyAction="http://tempuri.org/ISimpleBirthService/GetAgeSimpleResponse")]
        int GetAgeSimple(System.DateTime birthDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleBirthService/GetAgeSimple", ReplyAction="http://tempuri.org/ISimpleBirthService/GetAgeSimpleResponse")]
        System.Threading.Tasks.Task<int> GetAgeSimpleAsync(System.DateTime birthDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleBirthService/GetDifferenceSimple", ReplyAction="http://tempuri.org/ISimpleBirthService/GetDifferenceSimpleResponse")]
        int GetDifferenceSimple(System.DateTime first, System.DateTime second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleBirthService/GetDifferenceSimple", ReplyAction="http://tempuri.org/ISimpleBirthService/GetDifferenceSimpleResponse")]
        System.Threading.Tasks.Task<int> GetDifferenceSimpleAsync(System.DateTime first, System.DateTime second);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISimpleBirthServiceChannel : Client.Birth.ISimpleBirthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimpleBirthServiceClient : System.ServiceModel.ClientBase<Client.Birth.ISimpleBirthService>, Client.Birth.ISimpleBirthService {
        
        public SimpleBirthServiceClient() {
        }
        
        public SimpleBirthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimpleBirthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleBirthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleBirthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetAgeSimple(System.DateTime birthDate) {
            return base.Channel.GetAgeSimple(birthDate);
        }
        
        public System.Threading.Tasks.Task<int> GetAgeSimpleAsync(System.DateTime birthDate) {
            return base.Channel.GetAgeSimpleAsync(birthDate);
        }
        
        public int GetDifferenceSimple(System.DateTime first, System.DateTime second) {
            return base.Channel.GetDifferenceSimple(first, second);
        }
        
        public System.Threading.Tasks.Task<int> GetDifferenceSimpleAsync(System.DateTime first, System.DateTime second) {
            return base.Channel.GetDifferenceSimpleAsync(first, second);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Birth.IExactBirthService")]
    public interface IExactBirthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExactBirthService/GetAgeExact", ReplyAction="http://tempuri.org/IExactBirthService/GetAgeExactResponse")]
        int GetAgeExact(System.DateTime birthDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExactBirthService/GetAgeExact", ReplyAction="http://tempuri.org/IExactBirthService/GetAgeExactResponse")]
        System.Threading.Tasks.Task<int> GetAgeExactAsync(System.DateTime birthDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExactBirthService/GetDifferenceExact", ReplyAction="http://tempuri.org/IExactBirthService/GetDifferenceExactResponse")]
        int GetDifferenceExact(System.DateTime first, System.DateTime second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExactBirthService/GetDifferenceExact", ReplyAction="http://tempuri.org/IExactBirthService/GetDifferenceExactResponse")]
        System.Threading.Tasks.Task<int> GetDifferenceExactAsync(System.DateTime first, System.DateTime second);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExactBirthServiceChannel : Client.Birth.IExactBirthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExactBirthServiceClient : System.ServiceModel.ClientBase<Client.Birth.IExactBirthService>, Client.Birth.IExactBirthService {
        
        public ExactBirthServiceClient() {
        }
        
        public ExactBirthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExactBirthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExactBirthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExactBirthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetAgeExact(System.DateTime birthDate) {
            return base.Channel.GetAgeExact(birthDate);
        }
        
        public System.Threading.Tasks.Task<int> GetAgeExactAsync(System.DateTime birthDate) {
            return base.Channel.GetAgeExactAsync(birthDate);
        }
        
        public int GetDifferenceExact(System.DateTime first, System.DateTime second) {
            return base.Channel.GetDifferenceExact(first, second);
        }
        
        public System.Threading.Tasks.Task<int> GetDifferenceExactAsync(System.DateTime first, System.DateTime second) {
            return base.Channel.GetDifferenceExactAsync(first, second);
        }
    }
}
