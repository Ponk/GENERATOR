﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34003
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFDecrypt.ServiceCom {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCom.IServiceCom")]
    public interface IServiceCom {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCom/GetData", ReplyAction="http://tempuri.org/IServiceCom/GetDataResponse")]
        void GetData(string DocName, string DocContent, string DocKey, string DocMail, double DocTaux);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCom/GetData", ReplyAction="http://tempuri.org/IServiceCom/GetDataResponse")]
        System.Threading.Tasks.Task GetDataAsync(string DocName, string DocContent, string DocKey, string DocMail, double DocTaux);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCom/isDecrypt", ReplyAction="http://tempuri.org/IServiceCom/isDecryptResponse")]
        string[] isDecrypt();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCom/isDecrypt", ReplyAction="http://tempuri.org/IServiceCom/isDecryptResponse")]
        System.Threading.Tasks.Task<string[]> isDecryptAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCom/Reset", ReplyAction="http://tempuri.org/IServiceCom/ResetResponse")]
        void Reset();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCom/Reset", ReplyAction="http://tempuri.org/IServiceCom/ResetResponse")]
        System.Threading.Tasks.Task ResetAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceComChannel : WCFDecrypt.ServiceCom.IServiceCom, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceComClient : System.ServiceModel.ClientBase<WCFDecrypt.ServiceCom.IServiceCom>, WCFDecrypt.ServiceCom.IServiceCom {
        
        public ServiceComClient() {
        }
        
        public ServiceComClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceComClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceComClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceComClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void GetData(string DocName, string DocContent, string DocKey, string DocMail, double DocTaux) {
            base.Channel.GetData(DocName, DocContent, DocKey, DocMail, DocTaux);
        }
        
        public System.Threading.Tasks.Task GetDataAsync(string DocName, string DocContent, string DocKey, string DocMail, double DocTaux) {
            return base.Channel.GetDataAsync(DocName, DocContent, DocKey, DocMail, DocTaux);
        }
        
        public string[] isDecrypt() {
            return base.Channel.isDecrypt();
        }
        
        public System.Threading.Tasks.Task<string[]> isDecryptAsync() {
            return base.Channel.isDecryptAsync();
        }
        
        public void Reset() {
            base.Channel.Reset();
        }
        
        public System.Threading.Tasks.Task ResetAsync() {
            return base.Channel.ResetAsync();
        }
    }
}
