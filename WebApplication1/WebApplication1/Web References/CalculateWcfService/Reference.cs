﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace WebApplication1.CalculateWcfService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="basichttpbinding_CalculateService", Namespace="http://tempuri.org/")]
    public partial class CalculateService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddOperationOperationCompleted;
        
        private System.Threading.SendOrPostCallback SubOperationOperationCompleted;
        
        private System.Threading.SendOrPostCallback MulOperationOperationCompleted;
        
        private System.Threading.SendOrPostCallback DivOperationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CalculateService() {
            this.Url = global::WebApplication1.Properties.Settings.Default.WebApplication1_CalculateWcfService_CalculateService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddOperationCompletedEventHandler AddOperationCompleted;
        
        /// <remarks/>
        public event SubOperationCompletedEventHandler SubOperationCompleted;
        
        /// <remarks/>
        public event MulOperationCompletedEventHandler MulOperationCompleted;
        
        /// <remarks/>
        public event DivOperationCompletedEventHandler DivOperationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalculateService/AddOperation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddOperation(double num1, [System.Xml.Serialization.XmlIgnoreAttribute()] bool num1Specified, double num2, [System.Xml.Serialization.XmlIgnoreAttribute()] bool num2Specified, out double AddOperationResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool AddOperationResultSpecified) {
            object[] results = this.Invoke("AddOperation", new object[] {
                        num1,
                        num1Specified,
                        num2,
                        num2Specified});
            AddOperationResult = ((double)(results[0]));
            AddOperationResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void AddOperationAsync(double num1, bool num1Specified, double num2, bool num2Specified) {
            this.AddOperationAsync(num1, num1Specified, num2, num2Specified, null);
        }
        
        /// <remarks/>
        public void AddOperationAsync(double num1, bool num1Specified, double num2, bool num2Specified, object userState) {
            if ((this.AddOperationOperationCompleted == null)) {
                this.AddOperationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddOperationOperationCompleted);
            }
            this.InvokeAsync("AddOperation", new object[] {
                        num1,
                        num1Specified,
                        num2,
                        num2Specified}, this.AddOperationOperationCompleted, userState);
        }
        
        private void OnAddOperationOperationCompleted(object arg) {
            if ((this.AddOperationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddOperationCompleted(this, new AddOperationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalculateService/SubOperation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SubOperation(double num1, [System.Xml.Serialization.XmlIgnoreAttribute()] bool num1Specified, double num2, [System.Xml.Serialization.XmlIgnoreAttribute()] bool num2Specified, out double SubOperationResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool SubOperationResultSpecified) {
            object[] results = this.Invoke("SubOperation", new object[] {
                        num1,
                        num1Specified,
                        num2,
                        num2Specified});
            SubOperationResult = ((double)(results[0]));
            SubOperationResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void SubOperationAsync(double num1, bool num1Specified, double num2, bool num2Specified) {
            this.SubOperationAsync(num1, num1Specified, num2, num2Specified, null);
        }
        
        /// <remarks/>
        public void SubOperationAsync(double num1, bool num1Specified, double num2, bool num2Specified, object userState) {
            if ((this.SubOperationOperationCompleted == null)) {
                this.SubOperationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubOperationOperationCompleted);
            }
            this.InvokeAsync("SubOperation", new object[] {
                        num1,
                        num1Specified,
                        num2,
                        num2Specified}, this.SubOperationOperationCompleted, userState);
        }
        
        private void OnSubOperationOperationCompleted(object arg) {
            if ((this.SubOperationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubOperationCompleted(this, new SubOperationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalculateService/MulOperation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void MulOperation(double num1, [System.Xml.Serialization.XmlIgnoreAttribute()] bool num1Specified, double num2, [System.Xml.Serialization.XmlIgnoreAttribute()] bool num2Specified, out double MulOperationResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool MulOperationResultSpecified) {
            object[] results = this.Invoke("MulOperation", new object[] {
                        num1,
                        num1Specified,
                        num2,
                        num2Specified});
            MulOperationResult = ((double)(results[0]));
            MulOperationResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void MulOperationAsync(double num1, bool num1Specified, double num2, bool num2Specified) {
            this.MulOperationAsync(num1, num1Specified, num2, num2Specified, null);
        }
        
        /// <remarks/>
        public void MulOperationAsync(double num1, bool num1Specified, double num2, bool num2Specified, object userState) {
            if ((this.MulOperationOperationCompleted == null)) {
                this.MulOperationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMulOperationOperationCompleted);
            }
            this.InvokeAsync("MulOperation", new object[] {
                        num1,
                        num1Specified,
                        num2,
                        num2Specified}, this.MulOperationOperationCompleted, userState);
        }
        
        private void OnMulOperationOperationCompleted(object arg) {
            if ((this.MulOperationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MulOperationCompleted(this, new MulOperationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalculateService/DivOperation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DivOperation(double num1, [System.Xml.Serialization.XmlIgnoreAttribute()] bool num1Specified, double num2, [System.Xml.Serialization.XmlIgnoreAttribute()] bool num2Specified, out double DivOperationResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool DivOperationResultSpecified) {
            object[] results = this.Invoke("DivOperation", new object[] {
                        num1,
                        num1Specified,
                        num2,
                        num2Specified});
            DivOperationResult = ((double)(results[0]));
            DivOperationResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void DivOperationAsync(double num1, bool num1Specified, double num2, bool num2Specified) {
            this.DivOperationAsync(num1, num1Specified, num2, num2Specified, null);
        }
        
        /// <remarks/>
        public void DivOperationAsync(double num1, bool num1Specified, double num2, bool num2Specified, object userState) {
            if ((this.DivOperationOperationCompleted == null)) {
                this.DivOperationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDivOperationOperationCompleted);
            }
            this.InvokeAsync("DivOperation", new object[] {
                        num1,
                        num1Specified,
                        num2,
                        num2Specified}, this.DivOperationOperationCompleted, userState);
        }
        
        private void OnDivOperationOperationCompleted(object arg) {
            if ((this.DivOperationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DivOperationCompleted(this, new DivOperationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void AddOperationCompletedEventHandler(object sender, AddOperationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddOperationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddOperationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double AddOperationResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool AddOperationResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void SubOperationCompletedEventHandler(object sender, SubOperationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubOperationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SubOperationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double SubOperationResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool SubOperationResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void MulOperationCompletedEventHandler(object sender, MulOperationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MulOperationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MulOperationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double MulOperationResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool MulOperationResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void DivOperationCompletedEventHandler(object sender, DivOperationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DivOperationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DivOperationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double DivOperationResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool DivOperationResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591