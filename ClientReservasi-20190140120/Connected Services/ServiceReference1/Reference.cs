﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientReservasi_20190140120.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CekLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class CekLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeksripsiSingkatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaLokasiField;
        
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
        public string DeksripsiSingkat {
            get {
                return this.DeksripsiSingkatField;
            }
            set {
                if ((object.ReferenceEquals(this.DeksripsiSingkatField, value) != true)) {
                    this.DeksripsiSingkatField = value;
                    this.RaisePropertyChanged("DeksripsiSingkat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDLokasi {
            get {
                return this.IDLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.IDLokasiField, value) != true)) {
                    this.IDLokasiField = value;
                    this.RaisePropertyChanged("IDLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaLokasi {
            get {
                return this.NamaLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaLokasiField, value) != true)) {
                    this.NamaLokasiField = value;
                    this.RaisePropertyChanged("NamaLokasi");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailContract", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class DetailContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pemesanan", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class Pemesanan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDPemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int JumlahPemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaCustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoTelponField;
        
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
        public string IDLokasi {
            get {
                return this.IDLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.IDLokasiField, value) != true)) {
                    this.IDLokasiField = value;
                    this.RaisePropertyChanged("IDLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDPemesanan {
            get {
                return this.IDPemesananField;
            }
            set {
                if ((object.ReferenceEquals(this.IDPemesananField, value) != true)) {
                    this.IDPemesananField = value;
                    this.RaisePropertyChanged("IDPemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int JumlahPemesanan {
            get {
                return this.JumlahPemesananField;
            }
            set {
                if ((this.JumlahPemesananField.Equals(value) != true)) {
                    this.JumlahPemesananField = value;
                    this.RaisePropertyChanged("JumlahPemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaCustomer {
            get {
                return this.NamaCustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaCustomerField, value) != true)) {
                    this.NamaCustomerField = value;
                    this.RaisePropertyChanged("NamaCustomer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoTelpon {
            get {
                return this.NoTelponField;
            }
            set {
                if ((object.ReferenceEquals(this.NoTelponField, value) != true)) {
                    this.NoTelponField = value;
                    this.RaisePropertyChanged("NoTelpon");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        System.Threading.Tasks.Task<string> pemesananAsync(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        string editPemesanan(string IDPemesanan, string NamaCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        System.Threading.Tasks.Task<string> editPemesananAsync(string IDPemesanan, string NamaCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        string deletePemesanan(string IDPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        System.Threading.Tasks.Task<string> deletePemesananAsync(string IDPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        ClientReservasi_20190140120.ServiceReference1.CekLokasi[] ReviewLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140120.ServiceReference1.CekLokasi[]> ReviewLokasiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        ClientReservasi_20190140120.ServiceReference1.DetailContract[] DetailLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140120.ServiceReference1.DetailContract[]> DetailLokasiAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (Pemesanan) of message PemesananRequest does not match the default value (Pemesanan1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        ClientReservasi_20190140120.ServiceReference1.PemesananResponse Pemesanan1(ClientReservasi_20190140120.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140120.ServiceReference1.PemesananResponse> Pemesanan1Async(ClientReservasi_20190140120.ServiceReference1.PemesananRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Pemesanan", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananRequest {
        
        public PemesananRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PemesananResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ClientReservasi_20190140120.ServiceReference1.Pemesanan[] PemesananResult;
        
        public PemesananResponse() {
        }
        
        public PemesananResponse(ClientReservasi_20190140120.ServiceReference1.Pemesanan[] PemesananResult) {
            this.PemesananResult = PemesananResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientReservasi_20190140120.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientReservasi_20190140120.ServiceReference1.IService1>, ClientReservasi_20190140120.ServiceReference1.IService1 {
        
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
        
        public string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi) {
            return base.Channel.pemesanan(IDPemesanan, NamaCustomer, NoTelpon, JumlahPemesanan, IDLokasi);
        }
        
        public System.Threading.Tasks.Task<string> pemesananAsync(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi) {
            return base.Channel.pemesananAsync(IDPemesanan, NamaCustomer, NoTelpon, JumlahPemesanan, IDLokasi);
        }
        
        public string editPemesanan(string IDPemesanan, string NamaCustomer, string noTelpon) {
            return base.Channel.editPemesanan(IDPemesanan, NamaCustomer);
        }
        
        public System.Threading.Tasks.Task<string> editPemesananAsync(string IDPemesanan, string NamaCustomer) {
            return base.Channel.editPemesananAsync(IDPemesanan, NamaCustomer);
        }
        
        public string deletePemesanan(string IDPemesanan) {
            return base.Channel.deletePemesanan(IDPemesanan);
        }
        
        public System.Threading.Tasks.Task<string> deletePemesananAsync(string IDPemesanan) {
            return base.Channel.deletePemesananAsync(IDPemesanan);
        }
        
        public ClientReservasi_20190140120.ServiceReference1.CekLokasi[] ReviewLokasi() {
            return base.Channel.ReviewLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140120.ServiceReference1.CekLokasi[]> ReviewLokasiAsync() {
            return base.Channel.ReviewLokasiAsync();
        }
        
        public ClientReservasi_20190140120.ServiceReference1.DetailContract[] DetailLokasi() {
            return base.Channel.DetailLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140120.ServiceReference1.DetailContract[]> DetailLokasiAsync() {
            return base.Channel.DetailLokasiAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientReservasi_20190140120.ServiceReference1.PemesananResponse ClientReservasi_20190140120.ServiceReference1.IService1.Pemesanan1(ClientReservasi_20190140120.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1(request);
        }
        
        public ClientReservasi_20190140120.ServiceReference1.Pemesanan[] Pemesanan1() {
            ClientReservasi_20190140120.ServiceReference1.PemesananRequest inValue = new ClientReservasi_20190140120.ServiceReference1.PemesananRequest();
            ClientReservasi_20190140120.ServiceReference1.PemesananResponse retVal = ((ClientReservasi_20190140120.ServiceReference1.IService1)(this)).Pemesanan1(inValue);
            return retVal.PemesananResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientReservasi_20190140120.ServiceReference1.PemesananResponse> ClientReservasi_20190140120.ServiceReference1.IService1.Pemesanan1Async(ClientReservasi_20190140120.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1Async(request);
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140120.ServiceReference1.PemesananResponse> Pemesanan1Async() {
            ClientReservasi_20190140120.ServiceReference1.PemesananRequest inValue = new ClientReservasi_20190140120.ServiceReference1.PemesananRequest();
            return ((ClientReservasi_20190140120.ServiceReference1.IService1)(this)).Pemesanan1Async(inValue);
        }
    }
}
