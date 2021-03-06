﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wcf_EI_Polymorphism_Client.PersonReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/Wcf_EI_Polymorphism_Server.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wcf_EI_Polymorphism_Client.PersonReference.Teacher))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Wcf_EI_Polymorphism_Client.PersonReference.Secretary))]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PersonNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonId {
            get {
                return this.PersonIdField;
            }
            set {
                if ((this.PersonIdField.Equals(value) != true)) {
                    this.PersonIdField = value;
                    this.RaisePropertyChanged("PersonId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PersonName {
            get {
                return this.PersonNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonNameField, value) != true)) {
                    this.PersonNameField = value;
                    this.RaisePropertyChanged("PersonName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Teacher", Namespace="http://schemas.datacontract.org/2004/07/Wcf_EI_Polymorphism_Server.Model")]
    [System.SerializableAttribute()]
    public partial class Teacher : Wcf_EI_Polymorphism_Client.PersonReference.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SeniorityField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Seniority {
            get {
                return this.SeniorityField;
            }
            set {
                if ((this.SeniorityField.Equals(value) != true)) {
                    this.SeniorityField = value;
                    this.RaisePropertyChanged("Seniority");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Secretary", Namespace="http://schemas.datacontract.org/2004/07/Wcf_EI_Polymorphism_Server.Model")]
    [System.SerializableAttribute()]
    public partial class Secretary : Wcf_EI_Polymorphism_Client.PersonReference.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypingSpeedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TypingSpeed {
            get {
                return this.TypingSpeedField;
            }
            set {
                if ((this.TypingSpeedField.Equals(value) != true)) {
                    this.TypingSpeedField = value;
                    this.RaisePropertyChanged("TypingSpeed");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Global.PersonType", Namespace="http://schemas.datacontract.org/2004/07/Wcf_EI_Polymorphism_Server")]
    public enum GlobalPersonType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Person = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Teacher = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Secretary = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonReference.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAllPersons", ReplyAction="http://tempuri.org/IPersonService/GetAllPersonsResponse")]
        Wcf_EI_Polymorphism_Client.PersonReference.Person[] GetAllPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAllPersons", ReplyAction="http://tempuri.org/IPersonService/GetAllPersonsResponse")]
        System.Threading.Tasks.Task<Wcf_EI_Polymorphism_Client.PersonReference.Person[]> GetAllPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        int AddPerson(string Name, Wcf_EI_Polymorphism_Client.PersonReference.GlobalPersonType pType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        System.Threading.Tasks.Task<int> AddPersonAsync(string Name, Wcf_EI_Polymorphism_Client.PersonReference.GlobalPersonType pType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Display", ReplyAction="http://tempuri.org/IPersonService/DisplayResponse")]
        string Display(Wcf_EI_Polymorphism_Client.PersonReference.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Display", ReplyAction="http://tempuri.org/IPersonService/DisplayResponse")]
        System.Threading.Tasks.Task<string> DisplayAsync(Wcf_EI_Polymorphism_Client.PersonReference.Person p);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : Wcf_EI_Polymorphism_Client.PersonReference.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<Wcf_EI_Polymorphism_Client.PersonReference.IPersonService>, Wcf_EI_Polymorphism_Client.PersonReference.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Wcf_EI_Polymorphism_Client.PersonReference.Person[] GetAllPersons() {
            return base.Channel.GetAllPersons();
        }
        
        public System.Threading.Tasks.Task<Wcf_EI_Polymorphism_Client.PersonReference.Person[]> GetAllPersonsAsync() {
            return base.Channel.GetAllPersonsAsync();
        }
        
        public int AddPerson(string Name, Wcf_EI_Polymorphism_Client.PersonReference.GlobalPersonType pType) {
            return base.Channel.AddPerson(Name, pType);
        }
        
        public System.Threading.Tasks.Task<int> AddPersonAsync(string Name, Wcf_EI_Polymorphism_Client.PersonReference.GlobalPersonType pType) {
            return base.Channel.AddPersonAsync(Name, pType);
        }
        
        public string Display(Wcf_EI_Polymorphism_Client.PersonReference.Person p) {
            return base.Channel.Display(p);
        }
        
        public System.Threading.Tasks.Task<string> DisplayAsync(Wcf_EI_Polymorphism_Client.PersonReference.Person p) {
            return base.Channel.DisplayAsync(p);
        }
    }
}
