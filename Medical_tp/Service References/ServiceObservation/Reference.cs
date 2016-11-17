﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medical_tp.ServiceObservation {
    using System.Runtime.Serialization;
    using System;
    
    
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceObservation.IServiceObservation")]
    public interface IServiceObservation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceObservation/AddObservation", ReplyAction="http://tempuri.org/IServiceObservation/AddObservationResponse")]
        bool AddObservation(int idPatient, Medical_tp.ServiceObservation.Observation obs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceObservation/AddObservation", ReplyAction="http://tempuri.org/IServiceObservation/AddObservationResponse")]
        System.Threading.Tasks.Task<bool> AddObservationAsync(int idPatient, Medical_tp.ServiceObservation.Observation obs);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceObservationChannel : Medical_tp.ServiceObservation.IServiceObservation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceObservationClient : System.ServiceModel.ClientBase<Medical_tp.ServiceObservation.IServiceObservation>, Medical_tp.ServiceObservation.IServiceObservation {
        
        public ServiceObservationClient() {
        }
        
        public ServiceObservationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceObservationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceObservationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceObservationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddObservation(int idPatient, Medical_tp.ServiceObservation.Observation obs) {
            return base.Channel.AddObservation(idPatient, obs);
        }
        
        public System.Threading.Tasks.Task<bool> AddObservationAsync(int idPatient, Medical_tp.ServiceObservation.Observation obs) {
            return base.Channel.AddObservationAsync(idPatient, obs);
        }
    }
}
