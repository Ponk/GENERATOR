﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34003
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.WCFDecrypt {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFDecrypt.IServiceDecrypt")]
    public interface IServiceDecrypt {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDecrypt/EncryptDecrypt", ReplyAction="http://tempuri.org/IServiceDecrypt/EncryptDecryptResponse")]
        string[] EncryptDecrypt(string name, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDecrypt/EncryptDecrypt", ReplyAction="http://tempuri.org/IServiceDecrypt/EncryptDecryptResponse")]
        System.Threading.Tasks.Task<string[]> EncryptDecryptAsync(string name, string content);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceDecryptChannel : Client.WCFDecrypt.IServiceDecrypt, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDecryptClient : System.ServiceModel.ClientBase<Client.WCFDecrypt.IServiceDecrypt>, Client.WCFDecrypt.IServiceDecrypt {
        
        public ServiceDecryptClient() {
        }
        
        public ServiceDecryptClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDecryptClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDecryptClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDecryptClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] EncryptDecrypt(string name, string content) {
            return base.Channel.EncryptDecrypt(name, content);
        }
        
        public System.Threading.Tasks.Task<string[]> EncryptDecryptAsync(string name, string content) {
            return base.Channel.EncryptDecryptAsync(name, content);
        }
    }
}
