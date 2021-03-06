﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.41108.0
// 
namespace Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceBuilderParameter", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Test.Taupo.WebServices")]
    public partial class ServiceBuilderParameter : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string NameField;
        
        private string ValueField;
        
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
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AstoriaWorkspaceInfo", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Test.Taupo.WebServices", IsReference=true)]
    public partial class AstoriaWorkspaceInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.Generic.Dictionary<string, string> AdditionalProviderInfoField;
        
        private string ServiceUriField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> AdditionalProviderInfo {
            get {
                return this.AdditionalProviderInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.AdditionalProviderInfoField, value) != true)) {
                    this.AdditionalProviderInfoField = value;
                    this.RaisePropertyChanged("AdditionalProviderInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceUri {
            get {
                return this.ServiceUriField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceUriField, value) != true)) {
                    this.ServiceUriField = value;
                    this.RaisePropertyChanged("ServiceUri");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderSe" +
        "rvice")]
    public interface IDataServiceBuilderService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDataServiceBuilderService/CreateCustomDataService", ReplyAction="http://tempuri.org/IDataServiceBuilderService/CreateCustomDataServiceResponse")]
        System.IAsyncResult BeginCreateCustomDataService(string[] csdlContent, string dataProviderKind, string deployerKind, Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.ServiceBuilderParameter[] parameters, System.AsyncCallback callback, object asyncState);
        
        Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.AstoriaWorkspaceInfo EndCreateCustomDataService(out string errorLog, System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDataServiceBuilderService/GenerateClientLayerCode", ReplyAction="http://tempuri.org/IDataServiceBuilderService/GenerateClientLayerCodeResponse")]
        System.IAsyncResult BeginGenerateClientLayerCode(string dataServiceUri, string designVersion, string clientVersion, string fileExtension, System.AsyncCallback callback, object asyncState);
        
        string EndGenerateClientLayerCode(out string errorLog, System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDataServiceBuilderService/UninstallDataService", ReplyAction="http://tempuri.org/IDataServiceBuilderService/UninstallDataServiceResponse")]
        System.IAsyncResult BeginUninstallDataService(string dataServiceUri, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="errorLog")]
        string EndUninstallDataService(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceBuilderServiceChannel : Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateCustomDataServiceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CreateCustomDataServiceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string errorLog {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        public Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.AstoriaWorkspaceInfo Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.AstoriaWorkspaceInfo)(this.results[1]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GenerateClientLayerCodeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GenerateClientLayerCodeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string errorLog {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UninstallDataServiceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UninstallDataServiceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceBuilderServiceClient : System.ServiceModel.ClientBase<Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService>, Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService {
        
        private BeginOperationDelegate onBeginCreateCustomDataServiceDelegate;
        
        private EndOperationDelegate onEndCreateCustomDataServiceDelegate;
        
        private System.Threading.SendOrPostCallback onCreateCustomDataServiceCompletedDelegate;
        
        private BeginOperationDelegate onBeginGenerateClientLayerCodeDelegate;
        
        private EndOperationDelegate onEndGenerateClientLayerCodeDelegate;
        
        private System.Threading.SendOrPostCallback onGenerateClientLayerCodeCompletedDelegate;
        
        private BeginOperationDelegate onBeginUninstallDataServiceDelegate;
        
        private EndOperationDelegate onEndUninstallDataServiceDelegate;
        
        private System.Threading.SendOrPostCallback onUninstallDataServiceCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public DataServiceBuilderServiceClient() {
        }
        
        public DataServiceBuilderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceBuilderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceBuilderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceBuilderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<CreateCustomDataServiceCompletedEventArgs> CreateCustomDataServiceCompleted;
        
        public event System.EventHandler<GenerateClientLayerCodeCompletedEventArgs> GenerateClientLayerCodeCompleted;
        
        public event System.EventHandler<UninstallDataServiceCompletedEventArgs> UninstallDataServiceCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService.BeginCreateCustomDataService(string[] csdlContent, string dataProviderKind, string deployerKind, Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.ServiceBuilderParameter[] parameters, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreateCustomDataService(csdlContent, dataProviderKind, deployerKind, parameters, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.AstoriaWorkspaceInfo Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService.EndCreateCustomDataService(out string errorLog, System.IAsyncResult result) {
            return base.Channel.EndCreateCustomDataService(out errorLog, result);
        }
        
        private System.IAsyncResult OnBeginCreateCustomDataService(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string[] csdlContent = ((string[])(inValues[0]));
            string dataProviderKind = ((string)(inValues[1]));
            string deployerKind = ((string)(inValues[2]));
            Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.ServiceBuilderParameter[] parameters = ((Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.ServiceBuilderParameter[])(inValues[3]));
            return ((Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService)(this)).BeginCreateCustomDataService(csdlContent, dataProviderKind, deployerKind, parameters, callback, asyncState);
        }
        
        private object[] OnEndCreateCustomDataService(System.IAsyncResult result) {
            string errorLog = this.GetDefaultValueForInitialization<string>();
            Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.AstoriaWorkspaceInfo retVal = ((Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService)(this)).EndCreateCustomDataService(out errorLog, result);
            return new object[] {
                    errorLog,
                    retVal};
        }
        
        private void OnCreateCustomDataServiceCompleted(object state) {
            if ((this.CreateCustomDataServiceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateCustomDataServiceCompleted(this, new CreateCustomDataServiceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateCustomDataServiceAsync(string[] csdlContent, string dataProviderKind, string deployerKind, Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.ServiceBuilderParameter[] parameters) {
            this.CreateCustomDataServiceAsync(csdlContent, dataProviderKind, deployerKind, parameters, null);
        }
        
        public void CreateCustomDataServiceAsync(string[] csdlContent, string dataProviderKind, string deployerKind, Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.ServiceBuilderParameter[] parameters, object userState) {
            if ((this.onBeginCreateCustomDataServiceDelegate == null)) {
                this.onBeginCreateCustomDataServiceDelegate = new BeginOperationDelegate(this.OnBeginCreateCustomDataService);
            }
            if ((this.onEndCreateCustomDataServiceDelegate == null)) {
                this.onEndCreateCustomDataServiceDelegate = new EndOperationDelegate(this.OnEndCreateCustomDataService);
            }
            if ((this.onCreateCustomDataServiceCompletedDelegate == null)) {
                this.onCreateCustomDataServiceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateCustomDataServiceCompleted);
            }
            base.InvokeAsync(this.onBeginCreateCustomDataServiceDelegate, new object[] {
                        csdlContent,
                        dataProviderKind,
                        deployerKind,
                        parameters}, this.onEndCreateCustomDataServiceDelegate, this.onCreateCustomDataServiceCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService.BeginGenerateClientLayerCode(string dataServiceUri, string designVersion, string clientVersion, string fileExtension, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGenerateClientLayerCode(dataServiceUri, designVersion, clientVersion, fileExtension, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService.EndGenerateClientLayerCode(out string errorLog, System.IAsyncResult result) {
            return base.Channel.EndGenerateClientLayerCode(out errorLog, result);
        }
        
        private System.IAsyncResult OnBeginGenerateClientLayerCode(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string dataServiceUri = ((string)(inValues[0]));
            string designVersion = ((string)(inValues[1]));
            string clientVersion = ((string)(inValues[2]));
            string fileExtension = ((string)(inValues[3]));
            return ((Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService)(this)).BeginGenerateClientLayerCode(dataServiceUri, designVersion, clientVersion, fileExtension, callback, asyncState);
        }
        
        private object[] OnEndGenerateClientLayerCode(System.IAsyncResult result) {
            string errorLog = this.GetDefaultValueForInitialization<string>();
            string retVal = ((Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService)(this)).EndGenerateClientLayerCode(out errorLog, result);
            return new object[] {
                    errorLog,
                    retVal};
        }
        
        private void OnGenerateClientLayerCodeCompleted(object state) {
            if ((this.GenerateClientLayerCodeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GenerateClientLayerCodeCompleted(this, new GenerateClientLayerCodeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GenerateClientLayerCodeAsync(string dataServiceUri, string designVersion, string clientVersion, string fileExtension) {
            this.GenerateClientLayerCodeAsync(dataServiceUri, designVersion, clientVersion, fileExtension, null);
        }
        
        public void GenerateClientLayerCodeAsync(string dataServiceUri, string designVersion, string clientVersion, string fileExtension, object userState) {
            if ((this.onBeginGenerateClientLayerCodeDelegate == null)) {
                this.onBeginGenerateClientLayerCodeDelegate = new BeginOperationDelegate(this.OnBeginGenerateClientLayerCode);
            }
            if ((this.onEndGenerateClientLayerCodeDelegate == null)) {
                this.onEndGenerateClientLayerCodeDelegate = new EndOperationDelegate(this.OnEndGenerateClientLayerCode);
            }
            if ((this.onGenerateClientLayerCodeCompletedDelegate == null)) {
                this.onGenerateClientLayerCodeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGenerateClientLayerCodeCompleted);
            }
            base.InvokeAsync(this.onBeginGenerateClientLayerCodeDelegate, new object[] {
                        dataServiceUri,
                        designVersion,
                        clientVersion,
                        fileExtension}, this.onEndGenerateClientLayerCodeDelegate, this.onGenerateClientLayerCodeCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService.BeginUninstallDataService(string dataServiceUri, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUninstallDataService(dataServiceUri, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService.EndUninstallDataService(System.IAsyncResult result) {
            return base.Channel.EndUninstallDataService(result);
        }
        
        private System.IAsyncResult OnBeginUninstallDataService(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string dataServiceUri = ((string)(inValues[0]));
            return ((Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService)(this)).BeginUninstallDataService(dataServiceUri, callback, asyncState);
        }
        
        private object[] OnEndUninstallDataService(System.IAsyncResult result) {
            string retVal = ((Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService)(this)).EndUninstallDataService(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUninstallDataServiceCompleted(object state) {
            if ((this.UninstallDataServiceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UninstallDataServiceCompleted(this, new UninstallDataServiceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UninstallDataServiceAsync(string dataServiceUri) {
            this.UninstallDataServiceAsync(dataServiceUri, null);
        }
        
        public void UninstallDataServiceAsync(string dataServiceUri, object userState) {
            if ((this.onBeginUninstallDataServiceDelegate == null)) {
                this.onBeginUninstallDataServiceDelegate = new BeginOperationDelegate(this.OnBeginUninstallDataService);
            }
            if ((this.onEndUninstallDataServiceDelegate == null)) {
                this.onEndUninstallDataServiceDelegate = new EndOperationDelegate(this.OnEndUninstallDataService);
            }
            if ((this.onUninstallDataServiceCompletedDelegate == null)) {
                this.onUninstallDataServiceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUninstallDataServiceCompleted);
            }
            base.InvokeAsync(this.onBeginUninstallDataServiceDelegate, new object[] {
                        dataServiceUri}, this.onEndUninstallDataServiceDelegate, this.onUninstallDataServiceCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService CreateChannel() {
            return new DataServiceBuilderServiceClientChannel(this);
        }
        
        private class DataServiceBuilderServiceClientChannel : ChannelBase<Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService>, Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService {
            
            public DataServiceBuilderServiceClientChannel(System.ServiceModel.ClientBase<Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.IDataServiceBuilderService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginCreateCustomDataService(string[] csdlContent, string dataProviderKind, string deployerKind, Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.ServiceBuilderParameter[] parameters, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[4];
                _args[0] = csdlContent;
                _args[1] = dataProviderKind;
                _args[2] = deployerKind;
                _args[3] = parameters;
                System.IAsyncResult _result = base.BeginInvoke("CreateCustomDataService", _args, callback, asyncState);
                return _result;
            }
            
            public Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.AstoriaWorkspaceInfo EndCreateCustomDataService(out string errorLog, System.IAsyncResult result) {
                object[] _args = new object[1];
                Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.AstoriaWorkspaceInfo _result = ((Microsoft.Test.Taupo.Astoria.Contracts.WebServices.DataServiceBuilderService.Silverlight.AstoriaWorkspaceInfo)(base.EndInvoke("CreateCustomDataService", _args, result)));
                errorLog = ((string)(_args[0]));
                return _result;
            }
            
            public System.IAsyncResult BeginGenerateClientLayerCode(string dataServiceUri, string designVersion, string clientVersion, string fileExtension, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[4];
                _args[0] = dataServiceUri;
                _args[1] = designVersion;
                _args[2] = clientVersion;
                _args[3] = fileExtension;
                System.IAsyncResult _result = base.BeginInvoke("GenerateClientLayerCode", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGenerateClientLayerCode(out string errorLog, System.IAsyncResult result) {
                object[] _args = new object[1];
                string _result = ((string)(base.EndInvoke("GenerateClientLayerCode", _args, result)));
                errorLog = ((string)(_args[0]));
                return _result;
            }
            
            public System.IAsyncResult BeginUninstallDataService(string dataServiceUri, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = dataServiceUri;
                System.IAsyncResult _result = base.BeginInvoke("UninstallDataService", _args, callback, asyncState);
                return _result;
            }
            
            public string EndUninstallDataService(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("UninstallDataService", _args, result)));
                return _result;
            }
        }
    }
}
