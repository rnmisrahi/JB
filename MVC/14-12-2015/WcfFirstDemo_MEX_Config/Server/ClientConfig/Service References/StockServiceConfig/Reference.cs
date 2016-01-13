﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientConfig.StockServiceConfig {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StockServiceConfig.IStockServiceConfig")]
    public interface IStockServiceConfig {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockServiceConfig/DoWork", ReplyAction="http://tempuri.org/IStockServiceConfig/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockServiceConfig/DoWork", ReplyAction="http://tempuri.org/IStockServiceConfig/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockServiceConfig/GetPrice", ReplyAction="http://tempuri.org/IStockServiceConfig/GetPriceResponse")]
        double GetPrice(string productName, int prefix);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockServiceConfig/GetPrice", ReplyAction="http://tempuri.org/IStockServiceConfig/GetPriceResponse")]
        System.Threading.Tasks.Task<double> GetPriceAsync(string productName, int prefix);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockServiceConfig/GetMessage", ReplyAction="http://tempuri.org/IStockServiceConfig/GetMessageResponse")]
        string GetMessage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockServiceConfig/GetMessage", ReplyAction="http://tempuri.org/IStockServiceConfig/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockServiceConfig/GetMessageX", ReplyAction="http://tempuri.org/IStockServiceConfig/GetMessageXResponse")]
        string GetMessageX(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockServiceConfig/GetMessageX", ReplyAction="http://tempuri.org/IStockServiceConfig/GetMessageXResponse")]
        System.Threading.Tasks.Task<string> GetMessageXAsync(int x);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStockServiceConfigChannel : ClientConfig.StockServiceConfig.IStockServiceConfig, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockServiceConfigClient : System.ServiceModel.ClientBase<ClientConfig.StockServiceConfig.IStockServiceConfig>, ClientConfig.StockServiceConfig.IStockServiceConfig {
        
        public StockServiceConfigClient() {
        }
        
        public StockServiceConfigClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockServiceConfigClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceConfigClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceConfigClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public double GetPrice(string productName, int prefix) {
            return base.Channel.GetPrice(productName, prefix);
        }
        
        public System.Threading.Tasks.Task<double> GetPriceAsync(string productName, int prefix) {
            return base.Channel.GetPriceAsync(productName, prefix);
        }
        
        public string GetMessage() {
            return base.Channel.GetMessage();
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync() {
            return base.Channel.GetMessageAsync();
        }
        
        public string GetMessageX(int x) {
            return base.Channel.GetMessageX(x);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageXAsync(int x) {
            return base.Channel.GetMessageXAsync(x);
        }
    }
}
