﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackupAdmin.ServerReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Daemon", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Daemon : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DaemonNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PcNameField;
        
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
        public string DaemonName {
            get {
                return this.DaemonNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DaemonNameField, value) != true)) {
                    this.DaemonNameField = value;
                    this.RaisePropertyChanged("DaemonName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IpAddress {
            get {
                return this.IpAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddressField, value) != true)) {
                    this.IpAddressField = value;
                    this.RaisePropertyChanged("IpAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastActive {
            get {
                return this.LastActiveField;
            }
            set {
                if ((this.LastActiveField.Equals(value) != true)) {
                    this.LastActiveField = value;
                    this.RaisePropertyChanged("LastActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PcName {
            get {
                return this.PcNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PcNameField, value) != true)) {
                    this.PcNameField = value;
                    this.RaisePropertyChanged("PcName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServerReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UploadString", ReplyAction="http://tempuri.org/IService1/UploadStringResponse")]
        void UploadString(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UploadString", ReplyAction="http://tempuri.org/IService1/UploadStringResponse")]
        System.Threading.Tasks.Task UploadStringAsync(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UploadDaemon", ReplyAction="http://tempuri.org/IService1/UploadDaemonResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BackupAdmin.ServerReference.Daemon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BackupAdmin.ServerReference.CompositeType))]
        void UploadDaemon(object o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UploadDaemon", ReplyAction="http://tempuri.org/IService1/UploadDaemonResponse")]
        System.Threading.Tasks.Task UploadDaemonAsync(object o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDaemon", ReplyAction="http://tempuri.org/IService1/GetDaemonResponse")]
        BackupAdmin.ServerReference.Daemon GetDaemon(BackupAdmin.ServerReference.Daemon o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDaemon", ReplyAction="http://tempuri.org/IService1/GetDaemonResponse")]
        System.Threading.Tasks.Task<BackupAdmin.ServerReference.Daemon> GetDaemonAsync(BackupAdmin.ServerReference.Daemon o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        BackupAdmin.ServerReference.CompositeType GetDataUsingDataContract(BackupAdmin.ServerReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<BackupAdmin.ServerReference.CompositeType> GetDataUsingDataContractAsync(BackupAdmin.ServerReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : BackupAdmin.ServerReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<BackupAdmin.ServerReference.IService1>, BackupAdmin.ServerReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void UploadString(string s) {
            base.Channel.UploadString(s);
        }
        
        public System.Threading.Tasks.Task UploadStringAsync(string s) {
            return base.Channel.UploadStringAsync(s);
        }
        
        public void UploadDaemon(object o) {
            base.Channel.UploadDaemon(o);
        }
        
        public System.Threading.Tasks.Task UploadDaemonAsync(object o) {
            return base.Channel.UploadDaemonAsync(o);
        }
        
        public BackupAdmin.ServerReference.Daemon GetDaemon(BackupAdmin.ServerReference.Daemon o) {
            return base.Channel.GetDaemon(o);
        }
        
        public System.Threading.Tasks.Task<BackupAdmin.ServerReference.Daemon> GetDaemonAsync(BackupAdmin.ServerReference.Daemon o) {
            return base.Channel.GetDaemonAsync(o);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public BackupAdmin.ServerReference.CompositeType GetDataUsingDataContract(BackupAdmin.ServerReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<BackupAdmin.ServerReference.CompositeType> GetDataUsingDataContractAsync(BackupAdmin.ServerReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
