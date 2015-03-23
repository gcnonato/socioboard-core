﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace SocioboardDataServices.Api.Instagram {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="InstagramSoap", Namespace="http://tempuri.org/")]
    public partial class Instagram : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getInstagramDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback SheduleInstagramMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetInstagramRedirectUrlOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddInstagramAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetIntagramImagesOperationCompleted;
        
        private System.Threading.SendOrPostCallback InstagramLikeUnLikeOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllInstagramAccountsOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateInstagramAccountByAdminOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Instagram() {
            this.Url = global::SocioboardDataServices.Properties.Settings.Default.SocioboardDataServices_Api_Instagram_Instagram;
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
        public event getInstagramDataCompletedEventHandler getInstagramDataCompleted;
        
        /// <remarks/>
        public event SheduleInstagramMessageCompletedEventHandler SheduleInstagramMessageCompleted;
        
        /// <remarks/>
        public event GetInstagramRedirectUrlCompletedEventHandler GetInstagramRedirectUrlCompleted;
        
        /// <remarks/>
        public event AddInstagramAccountCompletedEventHandler AddInstagramAccountCompleted;
        
        /// <remarks/>
        public event GetIntagramImagesCompletedEventHandler GetIntagramImagesCompleted;
        
        /// <remarks/>
        public event InstagramLikeUnLikeCompletedEventHandler InstagramLikeUnLikeCompleted;
        
        /// <remarks/>
        public event GetAllInstagramAccountsCompletedEventHandler GetAllInstagramAccountsCompleted;
        
        /// <remarks/>
        public event UpdateInstagramAccountByAdminCompletedEventHandler UpdateInstagramAccountByAdminCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getInstagramData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getInstagramData(string UserId, string InstagramId) {
            object[] results = this.Invoke("getInstagramData", new object[] {
                        UserId,
                        InstagramId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getInstagramDataAsync(string UserId, string InstagramId) {
            this.getInstagramDataAsync(UserId, InstagramId, null);
        }
        
        /// <remarks/>
        public void getInstagramDataAsync(string UserId, string InstagramId, object userState) {
            if ((this.getInstagramDataOperationCompleted == null)) {
                this.getInstagramDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetInstagramDataOperationCompleted);
            }
            this.InvokeAsync("getInstagramData", new object[] {
                        UserId,
                        InstagramId}, this.getInstagramDataOperationCompleted, userState);
        }
        
        private void OngetInstagramDataOperationCompleted(object arg) {
            if ((this.getInstagramDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getInstagramDataCompleted(this, new getInstagramDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SheduleInstagramMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SheduleInstagramMessage(string InstagramId, string UserId, string sscheduledmsgguid) {
            object[] results = this.Invoke("SheduleInstagramMessage", new object[] {
                        InstagramId,
                        UserId,
                        sscheduledmsgguid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SheduleInstagramMessageAsync(string InstagramId, string UserId, string sscheduledmsgguid) {
            this.SheduleInstagramMessageAsync(InstagramId, UserId, sscheduledmsgguid, null);
        }
        
        /// <remarks/>
        public void SheduleInstagramMessageAsync(string InstagramId, string UserId, string sscheduledmsgguid, object userState) {
            if ((this.SheduleInstagramMessageOperationCompleted == null)) {
                this.SheduleInstagramMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSheduleInstagramMessageOperationCompleted);
            }
            this.InvokeAsync("SheduleInstagramMessage", new object[] {
                        InstagramId,
                        UserId,
                        sscheduledmsgguid}, this.SheduleInstagramMessageOperationCompleted, userState);
        }
        
        private void OnSheduleInstagramMessageOperationCompleted(object arg) {
            if ((this.SheduleInstagramMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SheduleInstagramMessageCompleted(this, new SheduleInstagramMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetInstagramRedirectUrl", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetInstagramRedirectUrl(string consumerKey, string consumerSecret, string CallBackUrl) {
            object[] results = this.Invoke("GetInstagramRedirectUrl", new object[] {
                        consumerKey,
                        consumerSecret,
                        CallBackUrl});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetInstagramRedirectUrlAsync(string consumerKey, string consumerSecret, string CallBackUrl) {
            this.GetInstagramRedirectUrlAsync(consumerKey, consumerSecret, CallBackUrl, null);
        }
        
        /// <remarks/>
        public void GetInstagramRedirectUrlAsync(string consumerKey, string consumerSecret, string CallBackUrl, object userState) {
            if ((this.GetInstagramRedirectUrlOperationCompleted == null)) {
                this.GetInstagramRedirectUrlOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetInstagramRedirectUrlOperationCompleted);
            }
            this.InvokeAsync("GetInstagramRedirectUrl", new object[] {
                        consumerKey,
                        consumerSecret,
                        CallBackUrl}, this.GetInstagramRedirectUrlOperationCompleted, userState);
        }
        
        private void OnGetInstagramRedirectUrlOperationCompleted(object arg) {
            if ((this.GetInstagramRedirectUrlCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetInstagramRedirectUrlCompleted(this, new GetInstagramRedirectUrlCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddInstagramAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddInstagramAccount(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            object[] results = this.Invoke("AddInstagramAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddInstagramAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            this.AddInstagramAccountAsync(client_id, client_secret, redirect_uri, UserId, GroupId, code, null);
        }
        
        /// <remarks/>
        public void AddInstagramAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code, object userState) {
            if ((this.AddInstagramAccountOperationCompleted == null)) {
                this.AddInstagramAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddInstagramAccountOperationCompleted);
            }
            this.InvokeAsync("AddInstagramAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code}, this.AddInstagramAccountOperationCompleted, userState);
        }
        
        private void OnAddInstagramAccountOperationCompleted(object arg) {
            if ((this.AddInstagramAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddInstagramAccountCompleted(this, new AddInstagramAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetIntagramImages", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetIntagramImages(InstagramAccount objInsAccount) {
            object[] results = this.Invoke("GetIntagramImages", new object[] {
                        objInsAccount});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetIntagramImagesAsync(InstagramAccount objInsAccount) {
            this.GetIntagramImagesAsync(objInsAccount, null);
        }
        
        /// <remarks/>
        public void GetIntagramImagesAsync(InstagramAccount objInsAccount, object userState) {
            if ((this.GetIntagramImagesOperationCompleted == null)) {
                this.GetIntagramImagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetIntagramImagesOperationCompleted);
            }
            this.InvokeAsync("GetIntagramImages", new object[] {
                        objInsAccount}, this.GetIntagramImagesOperationCompleted, userState);
        }
        
        private void OnGetIntagramImagesOperationCompleted(object arg) {
            if ((this.GetIntagramImagesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetIntagramImagesCompleted(this, new GetIntagramImagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InstagramLikeUnLike", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InstagramLikeUnLike(string LikeCount, string IsLike, string FeedId, string InstagramId, string UserId) {
            object[] results = this.Invoke("InstagramLikeUnLike", new object[] {
                        LikeCount,
                        IsLike,
                        FeedId,
                        InstagramId,
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InstagramLikeUnLikeAsync(string LikeCount, string IsLike, string FeedId, string InstagramId, string UserId) {
            this.InstagramLikeUnLikeAsync(LikeCount, IsLike, FeedId, InstagramId, UserId, null);
        }
        
        /// <remarks/>
        public void InstagramLikeUnLikeAsync(string LikeCount, string IsLike, string FeedId, string InstagramId, string UserId, object userState) {
            if ((this.InstagramLikeUnLikeOperationCompleted == null)) {
                this.InstagramLikeUnLikeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInstagramLikeUnLikeOperationCompleted);
            }
            this.InvokeAsync("InstagramLikeUnLike", new object[] {
                        LikeCount,
                        IsLike,
                        FeedId,
                        InstagramId,
                        UserId}, this.InstagramLikeUnLikeOperationCompleted, userState);
        }
        
        private void OnInstagramLikeUnLikeOperationCompleted(object arg) {
            if ((this.InstagramLikeUnLikeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InstagramLikeUnLikeCompleted(this, new InstagramLikeUnLikeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllInstagramAccounts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllInstagramAccounts() {
            object[] results = this.Invoke("GetAllInstagramAccounts", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllInstagramAccountsAsync() {
            this.GetAllInstagramAccountsAsync(null);
        }
        
        /// <remarks/>
        public void GetAllInstagramAccountsAsync(object userState) {
            if ((this.GetAllInstagramAccountsOperationCompleted == null)) {
                this.GetAllInstagramAccountsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllInstagramAccountsOperationCompleted);
            }
            this.InvokeAsync("GetAllInstagramAccounts", new object[0], this.GetAllInstagramAccountsOperationCompleted, userState);
        }
        
        private void OnGetAllInstagramAccountsOperationCompleted(object arg) {
            if ((this.GetAllInstagramAccountsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllInstagramAccountsCompleted(this, new GetAllInstagramAccountsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateInstagramAccountByAdmin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateInstagramAccountByAdmin(string ObjInstagram) {
            object[] results = this.Invoke("UpdateInstagramAccountByAdmin", new object[] {
                        ObjInstagram});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateInstagramAccountByAdminAsync(string ObjInstagram) {
            this.UpdateInstagramAccountByAdminAsync(ObjInstagram, null);
        }
        
        /// <remarks/>
        public void UpdateInstagramAccountByAdminAsync(string ObjInstagram, object userState) {
            if ((this.UpdateInstagramAccountByAdminOperationCompleted == null)) {
                this.UpdateInstagramAccountByAdminOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateInstagramAccountByAdminOperationCompleted);
            }
            this.InvokeAsync("UpdateInstagramAccountByAdmin", new object[] {
                        ObjInstagram}, this.UpdateInstagramAccountByAdminOperationCompleted, userState);
        }
        
        private void OnUpdateInstagramAccountByAdminOperationCompleted(object arg) {
            if ((this.UpdateInstagramAccountByAdminCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateInstagramAccountByAdminCompleted(this, new UpdateInstagramAccountByAdminCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class InstagramAccount {
        
        private System.Guid idField;
        
        private string instagramIdField;
        
        private string accessTokenField;
        
        private string insUserNameField;
        
        private System.Guid userIdField;
        
        private bool isActiveField;
        
        private int followersField;
        
        private int followedByField;
        
        private string profileUrlField;
        
        private int totalImagesField;
        
        private string profileTypeField;
        
        /// <remarks/>
        public System.Guid Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string InstagramId {
            get {
                return this.instagramIdField;
            }
            set {
                this.instagramIdField = value;
            }
        }
        
        /// <remarks/>
        public string AccessToken {
            get {
                return this.accessTokenField;
            }
            set {
                this.accessTokenField = value;
            }
        }
        
        /// <remarks/>
        public string InsUserName {
            get {
                return this.insUserNameField;
            }
            set {
                this.insUserNameField = value;
            }
        }
        
        /// <remarks/>
        public System.Guid UserId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public bool IsActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
            }
        }
        
        /// <remarks/>
        public int Followers {
            get {
                return this.followersField;
            }
            set {
                this.followersField = value;
            }
        }
        
        /// <remarks/>
        public int FollowedBy {
            get {
                return this.followedByField;
            }
            set {
                this.followedByField = value;
            }
        }
        
        /// <remarks/>
        public string ProfileUrl {
            get {
                return this.profileUrlField;
            }
            set {
                this.profileUrlField = value;
            }
        }
        
        /// <remarks/>
        public int TotalImages {
            get {
                return this.totalImagesField;
            }
            set {
                this.totalImagesField = value;
            }
        }
        
        /// <remarks/>
        public string ProfileType {
            get {
                return this.profileTypeField;
            }
            set {
                this.profileTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getInstagramDataCompletedEventHandler(object sender, getInstagramDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInstagramDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getInstagramDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void SheduleInstagramMessageCompletedEventHandler(object sender, SheduleInstagramMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SheduleInstagramMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SheduleInstagramMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetInstagramRedirectUrlCompletedEventHandler(object sender, GetInstagramRedirectUrlCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetInstagramRedirectUrlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetInstagramRedirectUrlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void AddInstagramAccountCompletedEventHandler(object sender, AddInstagramAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddInstagramAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddInstagramAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetIntagramImagesCompletedEventHandler(object sender, GetIntagramImagesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetIntagramImagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetIntagramImagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void InstagramLikeUnLikeCompletedEventHandler(object sender, InstagramLikeUnLikeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InstagramLikeUnLikeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InstagramLikeUnLikeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAllInstagramAccountsCompletedEventHandler(object sender, GetAllInstagramAccountsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllInstagramAccountsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllInstagramAccountsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void UpdateInstagramAccountByAdminCompletedEventHandler(object sender, UpdateInstagramAccountByAdminCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateInstagramAccountByAdminCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateInstagramAccountByAdminCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591