﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfInt", Namespace="http://tempuri.org/", ItemName="int")]
    [System.SerializableAttribute()]
    public class ArrayOfInt : System.Collections.Generic.List<int> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertDegrees", ReplyAction="*")]
        float ConvertDegrees(float degrees, char option);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertDegrees", ReplyAction="*")]
        System.Threading.Tasks.Task<float> ConvertDegreesAsync(float degrees, char option);
        
        // CODEGEN: Generating message contract since element name CurrentDateTimeResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CurrentDateTime", ReplyAction="*")]
        MyFirstClient.ServiceReference1.CurrentDateTimeResponse CurrentDateTime(MyFirstClient.ServiceReference1.CurrentDateTimeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CurrentDateTime", ReplyAction="*")]
        System.Threading.Tasks.Task<MyFirstClient.ServiceReference1.CurrentDateTimeResponse> CurrentDateTimeAsync(MyFirstClient.ServiceReference1.CurrentDateTimeRequest request);
        
        // CODEGEN: Generating message contract since element name ReturnListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReturnList", ReplyAction="*")]
        MyFirstClient.ServiceReference1.ReturnListResponse ReturnList(MyFirstClient.ServiceReference1.ReturnListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReturnList", ReplyAction="*")]
        System.Threading.Tasks.Task<MyFirstClient.ServiceReference1.ReturnListResponse> ReturnListAsync(MyFirstClient.ServiceReference1.ReturnListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertMoney", ReplyAction="*")]
        float ConvertMoney(float sum, char option);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertMoney", ReplyAction="*")]
        System.Threading.Tasks.Task<float> ConvertMoneyAsync(float sum, char option);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrentDateTimeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrentDateTime", Namespace="http://tempuri.org/", Order=0)]
        public MyFirstClient.ServiceReference1.CurrentDateTimeRequestBody Body;
        
        public CurrentDateTimeRequest() {
        }
        
        public CurrentDateTimeRequest(MyFirstClient.ServiceReference1.CurrentDateTimeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CurrentDateTimeRequestBody {
        
        public CurrentDateTimeRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrentDateTimeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrentDateTimeResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyFirstClient.ServiceReference1.CurrentDateTimeResponseBody Body;
        
        public CurrentDateTimeResponse() {
        }
        
        public CurrentDateTimeResponse(MyFirstClient.ServiceReference1.CurrentDateTimeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CurrentDateTimeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CurrentDateTimeResult;
        
        public CurrentDateTimeResponseBody() {
        }
        
        public CurrentDateTimeResponseBody(string CurrentDateTimeResult) {
            this.CurrentDateTimeResult = CurrentDateTimeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReturnListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReturnList", Namespace="http://tempuri.org/", Order=0)]
        public MyFirstClient.ServiceReference1.ReturnListRequestBody Body;
        
        public ReturnListRequest() {
        }
        
        public ReturnListRequest(MyFirstClient.ServiceReference1.ReturnListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ReturnListRequestBody {
        
        public ReturnListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReturnListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReturnListResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyFirstClient.ServiceReference1.ReturnListResponseBody Body;
        
        public ReturnListResponse() {
        }
        
        public ReturnListResponse(MyFirstClient.ServiceReference1.ReturnListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReturnListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyFirstClient.ServiceReference1.ArrayOfInt ReturnListResult;
        
        public ReturnListResponseBody() {
        }
        
        public ReturnListResponseBody(MyFirstClient.ServiceReference1.ArrayOfInt ReturnListResult) {
            this.ReturnListResult = ReturnListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : MyFirstClient.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<MyFirstClient.ServiceReference1.WebService1Soap>, MyFirstClient.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float ConvertDegrees(float degrees, char option) {
            return base.Channel.ConvertDegrees(degrees, option);
        }
        
        public System.Threading.Tasks.Task<float> ConvertDegreesAsync(float degrees, char option) {
            return base.Channel.ConvertDegreesAsync(degrees, option);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyFirstClient.ServiceReference1.CurrentDateTimeResponse MyFirstClient.ServiceReference1.WebService1Soap.CurrentDateTime(MyFirstClient.ServiceReference1.CurrentDateTimeRequest request) {
            return base.Channel.CurrentDateTime(request);
        }
        
        public string CurrentDateTime() {
            MyFirstClient.ServiceReference1.CurrentDateTimeRequest inValue = new MyFirstClient.ServiceReference1.CurrentDateTimeRequest();
            inValue.Body = new MyFirstClient.ServiceReference1.CurrentDateTimeRequestBody();
            MyFirstClient.ServiceReference1.CurrentDateTimeResponse retVal = ((MyFirstClient.ServiceReference1.WebService1Soap)(this)).CurrentDateTime(inValue);
            return retVal.Body.CurrentDateTimeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyFirstClient.ServiceReference1.CurrentDateTimeResponse> MyFirstClient.ServiceReference1.WebService1Soap.CurrentDateTimeAsync(MyFirstClient.ServiceReference1.CurrentDateTimeRequest request) {
            return base.Channel.CurrentDateTimeAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyFirstClient.ServiceReference1.CurrentDateTimeResponse> CurrentDateTimeAsync() {
            MyFirstClient.ServiceReference1.CurrentDateTimeRequest inValue = new MyFirstClient.ServiceReference1.CurrentDateTimeRequest();
            inValue.Body = new MyFirstClient.ServiceReference1.CurrentDateTimeRequestBody();
            return ((MyFirstClient.ServiceReference1.WebService1Soap)(this)).CurrentDateTimeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyFirstClient.ServiceReference1.ReturnListResponse MyFirstClient.ServiceReference1.WebService1Soap.ReturnList(MyFirstClient.ServiceReference1.ReturnListRequest request) {
            return base.Channel.ReturnList(request);
        }
        
        public MyFirstClient.ServiceReference1.ArrayOfInt ReturnList() {
            MyFirstClient.ServiceReference1.ReturnListRequest inValue = new MyFirstClient.ServiceReference1.ReturnListRequest();
            inValue.Body = new MyFirstClient.ServiceReference1.ReturnListRequestBody();
            MyFirstClient.ServiceReference1.ReturnListResponse retVal = ((MyFirstClient.ServiceReference1.WebService1Soap)(this)).ReturnList(inValue);
            return retVal.Body.ReturnListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyFirstClient.ServiceReference1.ReturnListResponse> MyFirstClient.ServiceReference1.WebService1Soap.ReturnListAsync(MyFirstClient.ServiceReference1.ReturnListRequest request) {
            return base.Channel.ReturnListAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyFirstClient.ServiceReference1.ReturnListResponse> ReturnListAsync() {
            MyFirstClient.ServiceReference1.ReturnListRequest inValue = new MyFirstClient.ServiceReference1.ReturnListRequest();
            inValue.Body = new MyFirstClient.ServiceReference1.ReturnListRequestBody();
            return ((MyFirstClient.ServiceReference1.WebService1Soap)(this)).ReturnListAsync(inValue);
        }
        
        public float ConvertMoney(float sum, char option) {
            return base.Channel.ConvertMoney(sum, option);
        }
        
        public System.Threading.Tasks.Task<float> ConvertMoneyAsync(float sum, char option) {
            return base.Channel.ConvertMoneyAsync(sum, option);
        }
    }
}
