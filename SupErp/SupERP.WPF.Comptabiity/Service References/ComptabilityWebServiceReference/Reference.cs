﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupERP.WPF.Comptabiity.ComptabilityWebServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClassOfAccount", Namespace="http://schemas.datacontract.org/2004/07/SupErp.BLL.ComptabilityBLL.BllObject")]
    [System.SerializableAttribute()]
    public partial class ClassOfAccount : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.ChartsOfAccount[] ChartsOfAccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> numberField;
        
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
        public SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.ChartsOfAccount[] ChartsOfAccount {
            get {
                return this.ChartsOfAccountField;
            }
            set {
                if ((object.ReferenceEquals(this.ChartsOfAccountField, value) != true)) {
                    this.ChartsOfAccountField = value;
                    this.RaisePropertyChanged("ChartsOfAccount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ChartsOfAccount", Namespace="http://schemas.datacontract.org/2004/07/SupErp.BLL.ComptabilityBLL.BllObject")]
    [System.SerializableAttribute()]
    public partial class ChartsOfAccount : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> account_numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.ChartsOfAccount[] chartsOfAccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> class_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public System.Nullable<long> account_number {
            get {
                return this.account_numberField;
            }
            set {
                if ((this.account_numberField.Equals(value) != true)) {
                    this.account_numberField = value;
                    this.RaisePropertyChanged("account_number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.ChartsOfAccount[] chartsOfAccount {
            get {
                return this.chartsOfAccountField;
            }
            set {
                if ((object.ReferenceEquals(this.chartsOfAccountField, value) != true)) {
                    this.chartsOfAccountField = value;
                    this.RaisePropertyChanged("chartsOfAccount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> class_id {
            get {
                return this.class_idField;
            }
            set {
                if ((this.class_idField.Equals(value) != true)) {
                    this.class_idField = value;
                    this.RaisePropertyChanged("class_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="COMPTA_ExchangeRate", Namespace="http://schemas.datacontract.org/2004/07/SupErp.Entities", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class COMPTA_ExchangeRate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> EURO_AUDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> EURO_GBPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> EURO_USDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> EURO_ZARField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> USD_EUROField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> updatedDateField;
        
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
        public System.Nullable<double> EURO_AUD {
            get {
                return this.EURO_AUDField;
            }
            set {
                if ((this.EURO_AUDField.Equals(value) != true)) {
                    this.EURO_AUDField = value;
                    this.RaisePropertyChanged("EURO_AUD");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> EURO_GBP {
            get {
                return this.EURO_GBPField;
            }
            set {
                if ((this.EURO_GBPField.Equals(value) != true)) {
                    this.EURO_GBPField = value;
                    this.RaisePropertyChanged("EURO_GBP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> EURO_USD {
            get {
                return this.EURO_USDField;
            }
            set {
                if ((this.EURO_USDField.Equals(value) != true)) {
                    this.EURO_USDField = value;
                    this.RaisePropertyChanged("EURO_USD");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> EURO_ZAR {
            get {
                return this.EURO_ZARField;
            }
            set {
                if ((this.EURO_ZARField.Equals(value) != true)) {
                    this.EURO_ZARField = value;
                    this.RaisePropertyChanged("EURO_ZAR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> USD_EURO {
            get {
                return this.USD_EUROField;
            }
            set {
                if ((this.USD_EUROField.Equals(value) != true)) {
                    this.USD_EUROField = value;
                    this.RaisePropertyChanged("USD_EURO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> updatedDate {
            get {
                return this.updatedDateField;
            }
            set {
                if ((this.updatedDateField.Equals(value) != true)) {
                    this.updatedDateField = value;
                    this.RaisePropertyChanged("updatedDate");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ComptabilityWebServiceReference.IComptabilityService")]
    public interface IComptabilityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComptabilityService/GetPlanComptable", ReplyAction="http://tempuri.org/IComptabilityService/GetPlanComptableResponse")]
        SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.ClassOfAccount[] GetPlanComptable();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComptabilityService/GetPlanComptable", ReplyAction="http://tempuri.org/IComptabilityService/GetPlanComptableResponse")]
        System.Threading.Tasks.Task<SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.ClassOfAccount[]> GetPlanComptableAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComptabilityService/GetExhangeRate", ReplyAction="http://tempuri.org/IComptabilityService/GetExhangeRateResponse")]
        SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.COMPTA_ExchangeRate GetExhangeRate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComptabilityService/GetExhangeRate", ReplyAction="http://tempuri.org/IComptabilityService/GetExhangeRateResponse")]
        System.Threading.Tasks.Task<SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.COMPTA_ExchangeRate> GetExhangeRateAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IComptabilityServiceChannel : SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.IComptabilityService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ComptabilityServiceClient : System.ServiceModel.ClientBase<SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.IComptabilityService>, SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.IComptabilityService {
        
        public ComptabilityServiceClient() {
        }
        
        public ComptabilityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ComptabilityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComptabilityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComptabilityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.ClassOfAccount[] GetPlanComptable() {
            return base.Channel.GetPlanComptable();
        }
        
        public System.Threading.Tasks.Task<SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.ClassOfAccount[]> GetPlanComptableAsync() {
            return base.Channel.GetPlanComptableAsync();
        }
        
        public SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.COMPTA_ExchangeRate GetExhangeRate() {
            return base.Channel.GetExhangeRate();
        }
        
        public System.Threading.Tasks.Task<SupERP.WPF.Comptabiity.ComptabilityWebServiceReference.COMPTA_ExchangeRate> GetExhangeRateAsync() {
            return base.Channel.GetExhangeRateAsync();
        }
    }
}
