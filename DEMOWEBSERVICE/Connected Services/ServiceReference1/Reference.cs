﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEMOWEBSERVICE.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getTableProcedurce", ReplyAction="http://tempuri.org/IService1/getTableProcedurceResponse")]
        System.Data.DataSet getTableProcedurce(string nameprocedurce, System.Collections.Generic.Dictionary<string, object> values);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getTableProcedurce", ReplyAction="http://tempuri.org/IService1/getTableProcedurceResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getTableProcedurceAsync(string nameprocedurce, System.Collections.Generic.Dictionary<string, object> values);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getTable", ReplyAction="http://tempuri.org/IService1/getTableResponse")]
        System.Data.DataSet getTable(string SQL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getTable", ReplyAction="http://tempuri.org/IService1/getTableResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getTableAsync(string SQL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ExeCuteSQL", ReplyAction="http://tempuri.org/IService1/ExeCuteSQLResponse")]
        int ExeCuteSQL(string SQL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ExeCuteSQL", ReplyAction="http://tempuri.org/IService1/ExeCuteSQLResponse")]
        System.Threading.Tasks.Task<int> ExeCuteSQLAsync(string SQL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ExeCuteProcedurce", ReplyAction="http://tempuri.org/IService1/ExeCuteProcedurceResponse")]
        int ExeCuteProcedurce(string nameprocedurce, System.Collections.Generic.Dictionary<string, object> values);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ExeCuteProcedurce", ReplyAction="http://tempuri.org/IService1/ExeCuteProcedurceResponse")]
        System.Threading.Tasks.Task<int> ExeCuteProcedurceAsync(string nameprocedurce, System.Collections.Generic.Dictionary<string, object> values);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DEMOWEBSERVICE.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DEMOWEBSERVICE.ServiceReference1.IService1>, DEMOWEBSERVICE.ServiceReference1.IService1 {
        
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
        
        public System.Data.DataSet getTableProcedurce(string nameprocedurce, System.Collections.Generic.Dictionary<string, object> values) {
            return base.Channel.getTableProcedurce(nameprocedurce, values);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getTableProcedurceAsync(string nameprocedurce, System.Collections.Generic.Dictionary<string, object> values) {
            return base.Channel.getTableProcedurceAsync(nameprocedurce, values);
        }
        
        public System.Data.DataSet getTable(string SQL) {
            return base.Channel.getTable(SQL);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getTableAsync(string SQL) {
            return base.Channel.getTableAsync(SQL);
        }
        
        public int ExeCuteSQL(string SQL) {
            return base.Channel.ExeCuteSQL(SQL);
        }
        
        public System.Threading.Tasks.Task<int> ExeCuteSQLAsync(string SQL) {
            return base.Channel.ExeCuteSQLAsync(SQL);
        }
        
        public int ExeCuteProcedurce(string nameprocedurce, System.Collections.Generic.Dictionary<string, object> values) {
            return base.Channel.ExeCuteProcedurce(nameprocedurce, values);
        }
        
        public System.Threading.Tasks.Task<int> ExeCuteProcedurceAsync(string nameprocedurce, System.Collections.Generic.Dictionary<string, object> values) {
            return base.Channel.ExeCuteProcedurceAsync(nameprocedurce, values);
        }
    }
}
