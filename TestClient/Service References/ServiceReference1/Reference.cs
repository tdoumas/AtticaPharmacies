﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AthensArea", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class AthensArea : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int _idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _descriptionField;
        
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
        public int _id {
            get {
                return this._idField;
            }
            set {
                if ((this._idField.Equals(value) != true)) {
                    this._idField = value;
                    this.RaisePropertyChanged("_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _description {
            get {
                return this._descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this._descriptionField, value) != true)) {
                    this._descriptionField = value;
                    this.RaisePropertyChanged("_description");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AvailableDates", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class AvailableDates : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _ShortDateStringField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string _ShortDateString {
            get {
                return this._ShortDateStringField;
            }
            set {
                if ((object.ReferenceEquals(this._ShortDateStringField, value) != true)) {
                    this._ShortDateStringField = value;
                    this.RaisePropertyChanged("_ShortDateString");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PharmacyOnDuty", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class PharmacyOnDuty : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PharmacistField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AthensAreaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OpeningHoursField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Pharmacist {
            get {
                return this.PharmacistField;
            }
            set {
                if ((object.ReferenceEquals(this.PharmacistField, value) != true)) {
                    this.PharmacistField = value;
                    this.RaisePropertyChanged("Pharmacist");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string AthensArea {
            get {
                return this.AthensAreaField;
            }
            set {
                if ((object.ReferenceEquals(this.AthensAreaField, value) != true)) {
                    this.AthensAreaField = value;
                    this.RaisePropertyChanged("AthensArea");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string TelNum {
            get {
                return this.TelNumField;
            }
            set {
                if ((object.ReferenceEquals(this.TelNumField, value) != true)) {
                    this.TelNumField = value;
                    this.RaisePropertyChanged("TelNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string OpeningHours {
            get {
                return this.OpeningHoursField;
            }
            set {
                if ((object.ReferenceEquals(this.OpeningHoursField, value) != true)) {
                    this.OpeningHoursField = value;
                    this.RaisePropertyChanged("OpeningHours");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since element name GetAvailableAthensAreasResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAvailableAthensAreas", ReplyAction="*")]
        TestClient.ServiceReference1.GetAvailableAthensAreasResponse GetAvailableAthensAreas(TestClient.ServiceReference1.GetAvailableAthensAreasRequest request);
        
        // CODEGEN: Generating message contract since element name Json_GetAvailableAthensAreasResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Json_GetAvailableAthensAreas", ReplyAction="*")]
        TestClient.ServiceReference1.Json_GetAvailableAthensAreasResponse Json_GetAvailableAthensAreas(TestClient.ServiceReference1.Json_GetAvailableAthensAreasRequest request);
        
        // CODEGEN: Generating message contract since element name Json_GetAvailableDatesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Json_GetAvailableDates", ReplyAction="*")]
        TestClient.ServiceReference1.Json_GetAvailableDatesResponse Json_GetAvailableDates(TestClient.ServiceReference1.Json_GetAvailableDatesRequest request);
        
        // CODEGEN: Generating message contract since element name GetAvailableDatesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAvailableDates", ReplyAction="*")]
        TestClient.ServiceReference1.GetAvailableDatesResponse GetAvailableDates(TestClient.ServiceReference1.GetAvailableDatesRequest request);
        
        // CODEGEN: Generating message contract since element name Area from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPharmaciesOnDuty", ReplyAction="*")]
        TestClient.ServiceReference1.GetPharmaciesOnDutyResponse GetPharmaciesOnDuty(TestClient.ServiceReference1.GetPharmaciesOnDutyRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAvailableAthensAreasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAvailableAthensAreas", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.GetAvailableAthensAreasRequestBody Body;
        
        public GetAvailableAthensAreasRequest() {
        }
        
        public GetAvailableAthensAreasRequest(TestClient.ServiceReference1.GetAvailableAthensAreasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAvailableAthensAreasRequestBody {
        
        public GetAvailableAthensAreasRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAvailableAthensAreasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAvailableAthensAreasResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.GetAvailableAthensAreasResponseBody Body;
        
        public GetAvailableAthensAreasResponse() {
        }
        
        public GetAvailableAthensAreasResponse(TestClient.ServiceReference1.GetAvailableAthensAreasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAvailableAthensAreasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TestClient.ServiceReference1.AthensArea[] GetAvailableAthensAreasResult;
        
        public GetAvailableAthensAreasResponseBody() {
        }
        
        public GetAvailableAthensAreasResponseBody(TestClient.ServiceReference1.AthensArea[] GetAvailableAthensAreasResult) {
            this.GetAvailableAthensAreasResult = GetAvailableAthensAreasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Json_GetAvailableAthensAreasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Json_GetAvailableAthensAreas", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.Json_GetAvailableAthensAreasRequestBody Body;
        
        public Json_GetAvailableAthensAreasRequest() {
        }
        
        public Json_GetAvailableAthensAreasRequest(TestClient.ServiceReference1.Json_GetAvailableAthensAreasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class Json_GetAvailableAthensAreasRequestBody {
        
        public Json_GetAvailableAthensAreasRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Json_GetAvailableAthensAreasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Json_GetAvailableAthensAreasResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.Json_GetAvailableAthensAreasResponseBody Body;
        
        public Json_GetAvailableAthensAreasResponse() {
        }
        
        public Json_GetAvailableAthensAreasResponse(TestClient.ServiceReference1.Json_GetAvailableAthensAreasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Json_GetAvailableAthensAreasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Json_GetAvailableAthensAreasResult;
        
        public Json_GetAvailableAthensAreasResponseBody() {
        }
        
        public Json_GetAvailableAthensAreasResponseBody(string Json_GetAvailableAthensAreasResult) {
            this.Json_GetAvailableAthensAreasResult = Json_GetAvailableAthensAreasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Json_GetAvailableDatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Json_GetAvailableDates", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.Json_GetAvailableDatesRequestBody Body;
        
        public Json_GetAvailableDatesRequest() {
        }
        
        public Json_GetAvailableDatesRequest(TestClient.ServiceReference1.Json_GetAvailableDatesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class Json_GetAvailableDatesRequestBody {
        
        public Json_GetAvailableDatesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Json_GetAvailableDatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Json_GetAvailableDatesResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.Json_GetAvailableDatesResponseBody Body;
        
        public Json_GetAvailableDatesResponse() {
        }
        
        public Json_GetAvailableDatesResponse(TestClient.ServiceReference1.Json_GetAvailableDatesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Json_GetAvailableDatesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Json_GetAvailableDatesResult;
        
        public Json_GetAvailableDatesResponseBody() {
        }
        
        public Json_GetAvailableDatesResponseBody(string Json_GetAvailableDatesResult) {
            this.Json_GetAvailableDatesResult = Json_GetAvailableDatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAvailableDatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAvailableDates", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.GetAvailableDatesRequestBody Body;
        
        public GetAvailableDatesRequest() {
        }
        
        public GetAvailableDatesRequest(TestClient.ServiceReference1.GetAvailableDatesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAvailableDatesRequestBody {
        
        public GetAvailableDatesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAvailableDatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAvailableDatesResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.GetAvailableDatesResponseBody Body;
        
        public GetAvailableDatesResponse() {
        }
        
        public GetAvailableDatesResponse(TestClient.ServiceReference1.GetAvailableDatesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAvailableDatesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TestClient.ServiceReference1.AvailableDates[] GetAvailableDatesResult;
        
        public GetAvailableDatesResponseBody() {
        }
        
        public GetAvailableDatesResponseBody(TestClient.ServiceReference1.AvailableDates[] GetAvailableDatesResult) {
            this.GetAvailableDatesResult = GetAvailableDatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPharmaciesOnDutyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPharmaciesOnDuty", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.GetPharmaciesOnDutyRequestBody Body;
        
        public GetPharmaciesOnDutyRequest() {
        }
        
        public GetPharmaciesOnDutyRequest(TestClient.ServiceReference1.GetPharmaciesOnDutyRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPharmaciesOnDutyRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TestClient.ServiceReference1.AthensArea Area;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public TestClient.ServiceReference1.AvailableDates Date;
        
        public GetPharmaciesOnDutyRequestBody() {
        }
        
        public GetPharmaciesOnDutyRequestBody(TestClient.ServiceReference1.AthensArea Area, TestClient.ServiceReference1.AvailableDates Date) {
            this.Area = Area;
            this.Date = Date;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPharmaciesOnDutyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPharmaciesOnDutyResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestClient.ServiceReference1.GetPharmaciesOnDutyResponseBody Body;
        
        public GetPharmaciesOnDutyResponse() {
        }
        
        public GetPharmaciesOnDutyResponse(TestClient.ServiceReference1.GetPharmaciesOnDutyResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPharmaciesOnDutyResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TestClient.ServiceReference1.PharmacyOnDuty[] GetPharmaciesOnDutyResult;
        
        public GetPharmaciesOnDutyResponseBody() {
        }
        
        public GetPharmaciesOnDutyResponseBody(TestClient.ServiceReference1.PharmacyOnDuty[] GetPharmaciesOnDutyResult) {
            this.GetPharmaciesOnDutyResult = GetPharmaciesOnDutyResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : TestClient.ServiceReference1.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<TestClient.ServiceReference1.Service1Soap>, TestClient.ServiceReference1.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestClient.ServiceReference1.GetAvailableAthensAreasResponse TestClient.ServiceReference1.Service1Soap.GetAvailableAthensAreas(TestClient.ServiceReference1.GetAvailableAthensAreasRequest request) {
            return base.Channel.GetAvailableAthensAreas(request);
        }
        
        public TestClient.ServiceReference1.AthensArea[] GetAvailableAthensAreas() {
            TestClient.ServiceReference1.GetAvailableAthensAreasRequest inValue = new TestClient.ServiceReference1.GetAvailableAthensAreasRequest();
            inValue.Body = new TestClient.ServiceReference1.GetAvailableAthensAreasRequestBody();
            TestClient.ServiceReference1.GetAvailableAthensAreasResponse retVal = ((TestClient.ServiceReference1.Service1Soap)(this)).GetAvailableAthensAreas(inValue);
            return retVal.Body.GetAvailableAthensAreasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestClient.ServiceReference1.Json_GetAvailableAthensAreasResponse TestClient.ServiceReference1.Service1Soap.Json_GetAvailableAthensAreas(TestClient.ServiceReference1.Json_GetAvailableAthensAreasRequest request) {
            return base.Channel.Json_GetAvailableAthensAreas(request);
        }
        
        public string Json_GetAvailableAthensAreas() {
            TestClient.ServiceReference1.Json_GetAvailableAthensAreasRequest inValue = new TestClient.ServiceReference1.Json_GetAvailableAthensAreasRequest();
            inValue.Body = new TestClient.ServiceReference1.Json_GetAvailableAthensAreasRequestBody();
            TestClient.ServiceReference1.Json_GetAvailableAthensAreasResponse retVal = ((TestClient.ServiceReference1.Service1Soap)(this)).Json_GetAvailableAthensAreas(inValue);
            return retVal.Body.Json_GetAvailableAthensAreasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestClient.ServiceReference1.Json_GetAvailableDatesResponse TestClient.ServiceReference1.Service1Soap.Json_GetAvailableDates(TestClient.ServiceReference1.Json_GetAvailableDatesRequest request) {
            return base.Channel.Json_GetAvailableDates(request);
        }
        
        public string Json_GetAvailableDates() {
            TestClient.ServiceReference1.Json_GetAvailableDatesRequest inValue = new TestClient.ServiceReference1.Json_GetAvailableDatesRequest();
            inValue.Body = new TestClient.ServiceReference1.Json_GetAvailableDatesRequestBody();
            TestClient.ServiceReference1.Json_GetAvailableDatesResponse retVal = ((TestClient.ServiceReference1.Service1Soap)(this)).Json_GetAvailableDates(inValue);
            return retVal.Body.Json_GetAvailableDatesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestClient.ServiceReference1.GetAvailableDatesResponse TestClient.ServiceReference1.Service1Soap.GetAvailableDates(TestClient.ServiceReference1.GetAvailableDatesRequest request) {
            return base.Channel.GetAvailableDates(request);
        }
        
        public TestClient.ServiceReference1.AvailableDates[] GetAvailableDates() {
            TestClient.ServiceReference1.GetAvailableDatesRequest inValue = new TestClient.ServiceReference1.GetAvailableDatesRequest();
            inValue.Body = new TestClient.ServiceReference1.GetAvailableDatesRequestBody();
            TestClient.ServiceReference1.GetAvailableDatesResponse retVal = ((TestClient.ServiceReference1.Service1Soap)(this)).GetAvailableDates(inValue);
            return retVal.Body.GetAvailableDatesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestClient.ServiceReference1.GetPharmaciesOnDutyResponse TestClient.ServiceReference1.Service1Soap.GetPharmaciesOnDuty(TestClient.ServiceReference1.GetPharmaciesOnDutyRequest request) {
            return base.Channel.GetPharmaciesOnDuty(request);
        }
        
        public TestClient.ServiceReference1.PharmacyOnDuty[] GetPharmaciesOnDuty(TestClient.ServiceReference1.AthensArea Area, TestClient.ServiceReference1.AvailableDates Date) {
            TestClient.ServiceReference1.GetPharmaciesOnDutyRequest inValue = new TestClient.ServiceReference1.GetPharmaciesOnDutyRequest();
            inValue.Body = new TestClient.ServiceReference1.GetPharmaciesOnDutyRequestBody();
            inValue.Body.Area = Area;
            inValue.Body.Date = Date;
            TestClient.ServiceReference1.GetPharmaciesOnDutyResponse retVal = ((TestClient.ServiceReference1.Service1Soap)(this)).GetPharmaciesOnDuty(inValue);
            return retVal.Body.GetPharmaciesOnDutyResult;
        }
    }
}
