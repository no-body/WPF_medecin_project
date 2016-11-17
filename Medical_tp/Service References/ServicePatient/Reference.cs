﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medical_tp.ServicePatient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/Dbo")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Medical_tp.ServicePatient.Observation[] ObservationsField;
        
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
        public System.DateTime Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((this.BirthdayField.Equals(value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Medical_tp.ServicePatient.Observation[] Observations {
            get {
                return this.ObservationsField;
            }
            set {
                if ((object.ReferenceEquals(this.ObservationsField, value) != true)) {
                    this.ObservationsField = value;
                    this.RaisePropertyChanged("Observations");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Observation", Namespace="http://schemas.datacontract.org/2004/07/Dbo")]
    [System.SerializableAttribute()]
    public partial class Observation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BloodPressureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[][] PicturesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] PrescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WeightField;
        
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
        public int BloodPressure {
            get {
                return this.BloodPressureField;
            }
            set {
                if ((this.BloodPressureField.Equals(value) != true)) {
                    this.BloodPressureField = value;
                    this.RaisePropertyChanged("BloodPressure");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[][] Pictures {
            get {
                return this.PicturesField;
            }
            set {
                if ((object.ReferenceEquals(this.PicturesField, value) != true)) {
                    this.PicturesField = value;
                    this.RaisePropertyChanged("Pictures");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Prescription {
            get {
                return this.PrescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.PrescriptionField, value) != true)) {
                    this.PrescriptionField = value;
                    this.RaisePropertyChanged("Prescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Weight {
            get {
                return this.WeightField;
            }
            set {
                if ((this.WeightField.Equals(value) != true)) {
                    this.WeightField = value;
                    this.RaisePropertyChanged("Weight");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicePatient.IServicePatient")]
    public interface IServicePatient {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePatient/GetListPatient", ReplyAction="http://tempuri.org/IServicePatient/GetListPatientResponse")]
        Medical_tp.ServicePatient.Patient[] GetListPatient();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePatient/GetListPatient", ReplyAction="http://tempuri.org/IServicePatient/GetListPatientResponse")]
        System.Threading.Tasks.Task<Medical_tp.ServicePatient.Patient[]> GetListPatientAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePatient/GetPatient", ReplyAction="http://tempuri.org/IServicePatient/GetPatientResponse")]
        Medical_tp.ServicePatient.Patient GetPatient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePatient/GetPatient", ReplyAction="http://tempuri.org/IServicePatient/GetPatientResponse")]
        System.Threading.Tasks.Task<Medical_tp.ServicePatient.Patient> GetPatientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePatient/AddPatient", ReplyAction="http://tempuri.org/IServicePatient/AddPatientResponse")]
        bool AddPatient(Medical_tp.ServicePatient.Patient user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePatient/AddPatient", ReplyAction="http://tempuri.org/IServicePatient/AddPatientResponse")]
        System.Threading.Tasks.Task<bool> AddPatientAsync(Medical_tp.ServicePatient.Patient user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePatient/DeletePatient", ReplyAction="http://tempuri.org/IServicePatient/DeletePatientResponse")]
        bool DeletePatient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePatient/DeletePatient", ReplyAction="http://tempuri.org/IServicePatient/DeletePatientResponse")]
        System.Threading.Tasks.Task<bool> DeletePatientAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePatientChannel : Medical_tp.ServicePatient.IServicePatient, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePatientClient : System.ServiceModel.ClientBase<Medical_tp.ServicePatient.IServicePatient>, Medical_tp.ServicePatient.IServicePatient {
        
        public ServicePatientClient() {
        }
        
        public ServicePatientClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePatientClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePatientClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePatientClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Medical_tp.ServicePatient.Patient[] GetListPatient() {
            return base.Channel.GetListPatient();
        }
        
        public System.Threading.Tasks.Task<Medical_tp.ServicePatient.Patient[]> GetListPatientAsync() {
            return base.Channel.GetListPatientAsync();
        }
        
        public Medical_tp.ServicePatient.Patient GetPatient(int id) {
            return base.Channel.GetPatient(id);
        }
        
        public System.Threading.Tasks.Task<Medical_tp.ServicePatient.Patient> GetPatientAsync(int id) {
            return base.Channel.GetPatientAsync(id);
        }
        
        public bool AddPatient(Medical_tp.ServicePatient.Patient user) {
            return base.Channel.AddPatient(user);
        }
        
        public System.Threading.Tasks.Task<bool> AddPatientAsync(Medical_tp.ServicePatient.Patient user) {
            return base.Channel.AddPatientAsync(user);
        }
        
        public bool DeletePatient(int id) {
            return base.Channel.DeletePatient(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeletePatientAsync(int id) {
            return base.Channel.DeletePatientAsync(id);
        }
    }
}
