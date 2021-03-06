﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcRateServiceReference1.CalcRateSoap")]
    public interface CalcRateSoap {
        
        // CODEGEN: Generating message contract since element name product from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Rate", ReplyAction="*")]
        MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateResponse Rate(MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Rate", ReplyAction="*")]
        System.Threading.Tasks.Task<MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateResponse> RateAsync(MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Rate", Namespace="http://tempuri.org/", Order=0)]
        public MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequestBody Body;
        
        public RateRequest() {
        }
        
        public RateRequest(MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string product;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string program;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.DateTime startdate;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime enddate;
        
        public RateRequestBody() {
        }
        
        public RateRequestBody(string product, string program, System.DateTime startdate, System.DateTime enddate) {
            this.product = product;
            this.program = program;
            this.startdate = startdate;
            this.enddate = enddate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RateResponse", Namespace="http://tempuri.org/", Order=0)]
        public MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateResponseBody Body;
        
        public RateResponse() {
        }
        
        public RateResponse(MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RateResult;
        
        public RateResponseBody() {
        }
        
        public RateResponseBody(string RateResult) {
            this.RateResult = RateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalcRateSoapChannel : MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.CalcRateSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcRateSoapClient : System.ServiceModel.ClientBase<MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.CalcRateSoap>, MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.CalcRateSoap {
        
        public CalcRateSoapClient() {
        }
        
        public CalcRateSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcRateSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcRateSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcRateSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateResponse MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.CalcRateSoap.Rate(MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequest request) {
            return base.Channel.Rate(request);
        }
        
        public string Rate(string product, string program, System.DateTime startdate, System.DateTime enddate) {
            MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequest inValue = new MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequest();
            inValue.Body = new MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequestBody();
            inValue.Body.product = product;
            inValue.Body.program = program;
            inValue.Body.startdate = startdate;
            inValue.Body.enddate = enddate;
            MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateResponse retVal = ((MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.CalcRateSoap)(this)).Rate(inValue);
            return retVal.Body.RateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateResponse> MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.CalcRateSoap.RateAsync(MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequest request) {
            return base.Channel.RateAsync(request);
        }
        
        public System.Threading.Tasks.Task<MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateResponse> RateAsync(string product, string program, System.DateTime startdate, System.DateTime enddate) {
            MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequest inValue = new MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequest();
            inValue.Body = new MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.RateRequestBody();
            inValue.Body.product = product;
            inValue.Body.program = program;
            inValue.Body.startdate = startdate;
            inValue.Body.enddate = enddate;
            return ((MCAP.Nova.UW.GetMinimumRate.CalcRateServiceReference1.CalcRateSoap)(this)).RateAsync(inValue);
        }
    }
}
