﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3625
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toyz4net.Core.RandomFontsWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebXml.com.cn/", ConfigurationName="RandomFontsWebService.RandomFontsWebServiceSoap")]
    public interface RandomFontsWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getChineseFonts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string[] getChineseFonts(int byFontsLength);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getCharFonts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string[] getCharFonts(int byFontsLength);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface RandomFontsWebServiceSoapChannel : Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class RandomFontsWebServiceSoapClient : System.ServiceModel.ClientBase<Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceSoap>, Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceSoap {
        
        public RandomFontsWebServiceSoapClient() {
        }
        
        public RandomFontsWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RandomFontsWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomFontsWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomFontsWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getChineseFonts(int byFontsLength) {
            return base.Channel.getChineseFonts(byFontsLength);
        }
        
        public string[] getCharFonts(int byFontsLength) {
            return base.Channel.getCharFonts(byFontsLength);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebXml.com.cn/", ConfigurationName="RandomFontsWebService.RandomFontsWebServiceHttpGet")]
    public interface RandomFontsWebServiceHttpGet {
        
        // CODEGEN: 操作 getChineseFonts 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/RandomFontsWebServiceHttpGet/getChineseFontsRequest", ReplyAction="http://WebXml.com.cn/RandomFontsWebServiceHttpGet/getChineseFontsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.RandomFontsWebService.getChineseFontsResponse getChineseFonts(Toyz4net.Core.RandomFontsWebService.getChineseFontsRequest request);
        
        // CODEGEN: 操作 getCharFonts 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/RandomFontsWebServiceHttpGet/getCharFontsRequest", ReplyAction="http://WebXml.com.cn/RandomFontsWebServiceHttpGet/getCharFontsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.RandomFontsWebService.getCharFontsResponse getCharFonts(Toyz4net.Core.RandomFontsWebService.getCharFontsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getChineseFontsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string byFontsLength;
        
        public getChineseFontsRequest() {
        }
        
        public getChineseFontsRequest(string byFontsLength) {
            this.byFontsLength = byFontsLength;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getChineseFontsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public string[] ArrayOfString;
        
        public getChineseFontsResponse() {
        }
        
        public getChineseFontsResponse(string[] ArrayOfString) {
            this.ArrayOfString = ArrayOfString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCharFontsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string byFontsLength;
        
        public getCharFontsRequest() {
        }
        
        public getCharFontsRequest(string byFontsLength) {
            this.byFontsLength = byFontsLength;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCharFontsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public string[] ArrayOfString;
        
        public getCharFontsResponse() {
        }
        
        public getCharFontsResponse(string[] ArrayOfString) {
            this.ArrayOfString = ArrayOfString;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface RandomFontsWebServiceHttpGetChannel : Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpGet, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class RandomFontsWebServiceHttpGetClient : System.ServiceModel.ClientBase<Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpGet>, Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpGet {
        
        public RandomFontsWebServiceHttpGetClient() {
        }
        
        public RandomFontsWebServiceHttpGetClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RandomFontsWebServiceHttpGetClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomFontsWebServiceHttpGetClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomFontsWebServiceHttpGetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.RandomFontsWebService.getChineseFontsResponse Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpGet.getChineseFonts(Toyz4net.Core.RandomFontsWebService.getChineseFontsRequest request) {
            return base.Channel.getChineseFonts(request);
        }
        
        public string[] getChineseFonts(string byFontsLength) {
            Toyz4net.Core.RandomFontsWebService.getChineseFontsRequest inValue = new Toyz4net.Core.RandomFontsWebService.getChineseFontsRequest();
            inValue.byFontsLength = byFontsLength;
            Toyz4net.Core.RandomFontsWebService.getChineseFontsResponse retVal = ((Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpGet)(this)).getChineseFonts(inValue);
            return retVal.ArrayOfString;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.RandomFontsWebService.getCharFontsResponse Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpGet.getCharFonts(Toyz4net.Core.RandomFontsWebService.getCharFontsRequest request) {
            return base.Channel.getCharFonts(request);
        }
        
        public string[] getCharFonts(string byFontsLength) {
            Toyz4net.Core.RandomFontsWebService.getCharFontsRequest inValue = new Toyz4net.Core.RandomFontsWebService.getCharFontsRequest();
            inValue.byFontsLength = byFontsLength;
            Toyz4net.Core.RandomFontsWebService.getCharFontsResponse retVal = ((Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpGet)(this)).getCharFonts(inValue);
            return retVal.ArrayOfString;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebXml.com.cn/", ConfigurationName="RandomFontsWebService.RandomFontsWebServiceHttpPost")]
    public interface RandomFontsWebServiceHttpPost {
        
        // CODEGEN: 操作 getChineseFonts 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/RandomFontsWebServiceHttpPost/getChineseFontsRequest", ReplyAction="http://WebXml.com.cn/RandomFontsWebServiceHttpPost/getChineseFontsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.RandomFontsWebService.getChineseFontsResponse1 getChineseFonts(Toyz4net.Core.RandomFontsWebService.getChineseFontsRequest1 request);
        
        // CODEGEN: 操作 getCharFonts 以后生成的消息协定不是 RPC，也不是换行文档。
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/RandomFontsWebServiceHttpPost/getCharFontsRequest", ReplyAction="http://WebXml.com.cn/RandomFontsWebServiceHttpPost/getCharFontsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Toyz4net.Core.RandomFontsWebService.getCharFontsResponse1 getCharFonts(Toyz4net.Core.RandomFontsWebService.getCharFontsRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getChineseFontsRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string byFontsLength;
        
        public getChineseFontsRequest1() {
        }
        
        public getChineseFontsRequest1(string byFontsLength) {
            this.byFontsLength = byFontsLength;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getChineseFontsResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public string[] ArrayOfString;
        
        public getChineseFontsResponse1() {
        }
        
        public getChineseFontsResponse1(string[] ArrayOfString) {
            this.ArrayOfString = ArrayOfString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCharFontsRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string byFontsLength;
        
        public getCharFontsRequest1() {
        }
        
        public getCharFontsRequest1(string byFontsLength) {
            this.byFontsLength = byFontsLength;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCharFontsResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebXml.com.cn/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public string[] ArrayOfString;
        
        public getCharFontsResponse1() {
        }
        
        public getCharFontsResponse1(string[] ArrayOfString) {
            this.ArrayOfString = ArrayOfString;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface RandomFontsWebServiceHttpPostChannel : Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpPost, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class RandomFontsWebServiceHttpPostClient : System.ServiceModel.ClientBase<Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpPost>, Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpPost {
        
        public RandomFontsWebServiceHttpPostClient() {
        }
        
        public RandomFontsWebServiceHttpPostClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RandomFontsWebServiceHttpPostClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomFontsWebServiceHttpPostClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomFontsWebServiceHttpPostClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.RandomFontsWebService.getChineseFontsResponse1 Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpPost.getChineseFonts(Toyz4net.Core.RandomFontsWebService.getChineseFontsRequest1 request) {
            return base.Channel.getChineseFonts(request);
        }
        
        public string[] getChineseFonts(string byFontsLength) {
            Toyz4net.Core.RandomFontsWebService.getChineseFontsRequest1 inValue = new Toyz4net.Core.RandomFontsWebService.getChineseFontsRequest1();
            inValue.byFontsLength = byFontsLength;
            Toyz4net.Core.RandomFontsWebService.getChineseFontsResponse1 retVal = ((Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpPost)(this)).getChineseFonts(inValue);
            return retVal.ArrayOfString;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Toyz4net.Core.RandomFontsWebService.getCharFontsResponse1 Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpPost.getCharFonts(Toyz4net.Core.RandomFontsWebService.getCharFontsRequest1 request) {
            return base.Channel.getCharFonts(request);
        }
        
        public string[] getCharFonts(string byFontsLength) {
            Toyz4net.Core.RandomFontsWebService.getCharFontsRequest1 inValue = new Toyz4net.Core.RandomFontsWebService.getCharFontsRequest1();
            inValue.byFontsLength = byFontsLength;
            Toyz4net.Core.RandomFontsWebService.getCharFontsResponse1 retVal = ((Toyz4net.Core.RandomFontsWebService.RandomFontsWebServiceHttpPost)(this)).getCharFonts(inValue);
            return retVal.ArrayOfString;
        }
    }
}
