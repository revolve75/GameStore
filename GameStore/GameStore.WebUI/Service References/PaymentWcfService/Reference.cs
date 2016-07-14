﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameStore.WebUI.PaymentWcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VisaPaymentInfo", Namespace="http://schemas.datacontract.org/2004/07/PaymentWCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class VisaPaymentInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CardNumberField;
        
        private int CvvField;
        
        private int ExpirationMonthField;
        
        private int ExpirationYearField;
        
        private string FullNameField;
        
        private string PayeeField;
        
        private decimal PaymentAmountField;
        
        private string PaymentPurposeField;
        
        private System.Guid TokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserEmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserPhoneNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string CardNumber {
            get {
                return this.CardNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CardNumberField, value) != true)) {
                    this.CardNumberField = value;
                    this.RaisePropertyChanged("CardNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Cvv {
            get {
                return this.CvvField;
            }
            set {
                if ((this.CvvField.Equals(value) != true)) {
                    this.CvvField = value;
                    this.RaisePropertyChanged("Cvv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ExpirationMonth {
            get {
                return this.ExpirationMonthField;
            }
            set {
                if ((this.ExpirationMonthField.Equals(value) != true)) {
                    this.ExpirationMonthField = value;
                    this.RaisePropertyChanged("ExpirationMonth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ExpirationYear {
            get {
                return this.ExpirationYearField;
            }
            set {
                if ((this.ExpirationYearField.Equals(value) != true)) {
                    this.ExpirationYearField = value;
                    this.RaisePropertyChanged("ExpirationYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Payee {
            get {
                return this.PayeeField;
            }
            set {
                if ((object.ReferenceEquals(this.PayeeField, value) != true)) {
                    this.PayeeField = value;
                    this.RaisePropertyChanged("Payee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal PaymentAmount {
            get {
                return this.PaymentAmountField;
            }
            set {
                if ((this.PaymentAmountField.Equals(value) != true)) {
                    this.PaymentAmountField = value;
                    this.RaisePropertyChanged("PaymentAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string PaymentPurpose {
            get {
                return this.PaymentPurposeField;
            }
            set {
                if ((object.ReferenceEquals(this.PaymentPurposeField, value) != true)) {
                    this.PaymentPurposeField = value;
                    this.RaisePropertyChanged("PaymentPurpose");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Guid Token {
            get {
                return this.TokenField;
            }
            set {
                if ((this.TokenField.Equals(value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserEmail {
            get {
                return this.UserEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.UserEmailField, value) != true)) {
                    this.UserEmailField = value;
                    this.RaisePropertyChanged("UserEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserPhoneNumber {
            get {
                return this.UserPhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.UserPhoneNumberField, value) != true)) {
                    this.UserPhoneNumberField = value;
                    this.RaisePropertyChanged("UserPhoneNumber");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaymentResult", Namespace="http://schemas.datacontract.org/2004/07/PaymentWCFService.Enums")]
    public enum PaymentResult : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotEnoughMoney = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CardDoesNotExist = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PayeeDoesNotExist = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WrongToken = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failure = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidationFault", Namespace="http://www.microsoft.com/practices/EnterpriseLibrary/2007/01/wcf/validation")]
    [System.SerializableAttribute()]
    public partial class ValidationFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GameStore.WebUI.PaymentWcfService.ValidationDetail[] DetailsField;
        
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
        public GameStore.WebUI.PaymentWcfService.ValidationDetail[] Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidationDetail", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Practices.EnterpriseLibrary.Val" +
        "idation.Integration.WCF")]
    [System.SerializableAttribute()]
    public partial class ValidationDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TagField;
        
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
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tag {
            get {
                return this.TagField;
            }
            set {
                if ((object.ReferenceEquals(this.TagField, value) != true)) {
                    this.TagField = value;
                    this.RaisePropertyChanged("Tag");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaymentWcfService.IPaymentWcfService")]
    public interface IPaymentWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentWcfService/GetToken", ReplyAction="http://tempuri.org/IPaymentWcfService/GetTokenResponse")]
        System.Guid GetToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentWcfService/GetToken", ReplyAction="http://tempuri.org/IPaymentWcfService/GetTokenResponse")]
        System.Threading.Tasks.Task<System.Guid> GetTokenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentWcfService/MakePayment", ReplyAction="http://tempuri.org/IPaymentWcfService/MakePaymentResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GameStore.WebUI.PaymentWcfService.ValidationFault), Action="http://tempuri.org/IPaymentWcfService/MakePaymentValidationFaultFault", Name="ValidationFault", Namespace="http://www.microsoft.com/practices/EnterpriseLibrary/2007/01/wcf/validation")]
        GameStore.WebUI.PaymentWcfService.PaymentResult MakePayment(GameStore.WebUI.PaymentWcfService.VisaPaymentInfo paymentInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentWcfService/MakePayment", ReplyAction="http://tempuri.org/IPaymentWcfService/MakePaymentResponse")]
        System.Threading.Tasks.Task<GameStore.WebUI.PaymentWcfService.PaymentResult> MakePaymentAsync(GameStore.WebUI.PaymentWcfService.VisaPaymentInfo paymentInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaymentWcfServiceChannel : GameStore.WebUI.PaymentWcfService.IPaymentWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentWcfServiceClient : System.ServiceModel.ClientBase<GameStore.WebUI.PaymentWcfService.IPaymentWcfService>, GameStore.WebUI.PaymentWcfService.IPaymentWcfService {
        
        public PaymentWcfServiceClient() {
        }
        
        public PaymentWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaymentWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Guid GetToken() {
            return base.Channel.GetToken();
        }
        
        public System.Threading.Tasks.Task<System.Guid> GetTokenAsync() {
            return base.Channel.GetTokenAsync();
        }
        
        public GameStore.WebUI.PaymentWcfService.PaymentResult MakePayment(GameStore.WebUI.PaymentWcfService.VisaPaymentInfo paymentInfo) {
            return base.Channel.MakePayment(paymentInfo);
        }
        
        public System.Threading.Tasks.Task<GameStore.WebUI.PaymentWcfService.PaymentResult> MakePaymentAsync(GameStore.WebUI.PaymentWcfService.VisaPaymentInfo paymentInfo) {
            return base.Channel.MakePaymentAsync(paymentInfo);
        }
    }
}
