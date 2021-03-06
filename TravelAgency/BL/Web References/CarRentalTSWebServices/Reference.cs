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

namespace BL.CarRentalTSWebServices {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TestService", Namespace="http://tempuri.org/")]
    public partial class SOAPHeaderService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private UserCredentials userCredentialsValueField;
        
        private System.Threading.SendOrPostCallback GetCarRentalsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCarOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAvailableCarsOperationCompleted;
        
        private System.Threading.SendOrPostCallback BookCarOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetBookedCarsOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateSlotOperationCompleted;
        
        private System.Threading.SendOrPostCallback ConfirmSlotOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteSlotOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SOAPHeaderService() {
            this.Url = global::BL.Properties.Settings.Default.BL_CarRentalTSWebServices_SOAPHeaderService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public UserCredentials UserCredentialsValue {
            get {
                return this.userCredentialsValueField;
            }
            set {
                this.userCredentialsValueField = value;
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
        public event GetCarRentalsCompletedEventHandler GetCarRentalsCompleted;
        
        /// <remarks/>
        public event GetCarCompletedEventHandler GetCarCompleted;
        
        /// <remarks/>
        public event GetAvailableCarsCompletedEventHandler GetAvailableCarsCompleted;
        
        /// <remarks/>
        public event BookCarCompletedEventHandler BookCarCompleted;
        
        /// <remarks/>
        public event GetBookedCarsCompletedEventHandler GetBookedCarsCompleted;
        
        /// <remarks/>
        public event UpdateSlotCompletedEventHandler UpdateSlotCompleted;
        
        /// <remarks/>
        public event ConfirmSlotCompletedEventHandler ConfirmSlotCompleted;
        
        /// <remarks/>
        public event DeleteSlotCompletedEventHandler DeleteSlotCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("UserCredentialsValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCarRentals", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetCarRentals() {
            object[] results = this.Invoke("GetCarRentals", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetCarRentalsAsync() {
            this.GetCarRentalsAsync(null);
        }
        
        /// <remarks/>
        public void GetCarRentalsAsync(object userState) {
            if ((this.GetCarRentalsOperationCompleted == null)) {
                this.GetCarRentalsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCarRentalsOperationCompleted);
            }
            this.InvokeAsync("GetCarRentals", new object[0], this.GetCarRentalsOperationCompleted, userState);
        }
        
        private void OnGetCarRentalsOperationCompleted(object arg) {
            if ((this.GetCarRentalsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCarRentalsCompleted(this, new GetCarRentalsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("UserCredentialsValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetCar(int carRentalId) {
            object[] results = this.Invoke("GetCar", new object[] {
                        carRentalId});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetCarAsync(int carRentalId) {
            this.GetCarAsync(carRentalId, null);
        }
        
        /// <remarks/>
        public void GetCarAsync(int carRentalId, object userState) {
            if ((this.GetCarOperationCompleted == null)) {
                this.GetCarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCarOperationCompleted);
            }
            this.InvokeAsync("GetCar", new object[] {
                        carRentalId}, this.GetCarOperationCompleted, userState);
        }
        
        private void OnGetCarOperationCompleted(object arg) {
            if ((this.GetCarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCarCompleted(this, new GetCarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("UserCredentialsValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAvailableCars", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetAvailableCars(int carRentalId, System.DateTime travelDate) {
            object[] results = this.Invoke("GetAvailableCars", new object[] {
                        carRentalId,
                        travelDate});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetAvailableCarsAsync(int carRentalId, System.DateTime travelDate) {
            this.GetAvailableCarsAsync(carRentalId, travelDate, null);
        }
        
        /// <remarks/>
        public void GetAvailableCarsAsync(int carRentalId, System.DateTime travelDate, object userState) {
            if ((this.GetAvailableCarsOperationCompleted == null)) {
                this.GetAvailableCarsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAvailableCarsOperationCompleted);
            }
            this.InvokeAsync("GetAvailableCars", new object[] {
                        carRentalId,
                        travelDate}, this.GetAvailableCarsOperationCompleted, userState);
        }
        
        private void OnGetAvailableCarsOperationCompleted(object arg) {
            if ((this.GetAvailableCarsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAvailableCarsCompleted(this, new GetAvailableCarsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("UserCredentialsValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BookCar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int BookCar(int carId, string carNumber, System.DateTime travelDate, bool isLocked, string passengerSSN, string updatedUser) {
            object[] results = this.Invoke("BookCar", new object[] {
                        carId,
                        carNumber,
                        travelDate,
                        isLocked,
                        passengerSSN,
                        updatedUser});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void BookCarAsync(int carId, string carNumber, System.DateTime travelDate, bool isLocked, string passengerSSN, string updatedUser) {
            this.BookCarAsync(carId, carNumber, travelDate, isLocked, passengerSSN, updatedUser, null);
        }
        
        /// <remarks/>
        public void BookCarAsync(int carId, string carNumber, System.DateTime travelDate, bool isLocked, string passengerSSN, string updatedUser, object userState) {
            if ((this.BookCarOperationCompleted == null)) {
                this.BookCarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBookCarOperationCompleted);
            }
            this.InvokeAsync("BookCar", new object[] {
                        carId,
                        carNumber,
                        travelDate,
                        isLocked,
                        passengerSSN,
                        updatedUser}, this.BookCarOperationCompleted, userState);
        }
        
        private void OnBookCarOperationCompleted(object arg) {
            if ((this.BookCarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BookCarCompleted(this, new BookCarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("UserCredentialsValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetBookedCars", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetBookedCars(int carId, System.DateTime travelDate) {
            object[] results = this.Invoke("GetBookedCars", new object[] {
                        carId,
                        travelDate});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetBookedCarsAsync(int carId, System.DateTime travelDate) {
            this.GetBookedCarsAsync(carId, travelDate, null);
        }
        
        /// <remarks/>
        public void GetBookedCarsAsync(int carId, System.DateTime travelDate, object userState) {
            if ((this.GetBookedCarsOperationCompleted == null)) {
                this.GetBookedCarsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBookedCarsOperationCompleted);
            }
            this.InvokeAsync("GetBookedCars", new object[] {
                        carId,
                        travelDate}, this.GetBookedCarsOperationCompleted, userState);
        }
        
        private void OnGetBookedCarsOperationCompleted(object arg) {
            if ((this.GetBookedCarsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBookedCarsCompleted(this, new GetBookedCarsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("UserCredentialsValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateSlot", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdateSlot(int bookId, int carId, System.DateTime travelDate) {
            object[] results = this.Invoke("UpdateSlot", new object[] {
                        bookId,
                        carId,
                        travelDate});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateSlotAsync(int bookId, int carId, System.DateTime travelDate) {
            this.UpdateSlotAsync(bookId, carId, travelDate, null);
        }
        
        /// <remarks/>
        public void UpdateSlotAsync(int bookId, int carId, System.DateTime travelDate, object userState) {
            if ((this.UpdateSlotOperationCompleted == null)) {
                this.UpdateSlotOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateSlotOperationCompleted);
            }
            this.InvokeAsync("UpdateSlot", new object[] {
                        bookId,
                        carId,
                        travelDate}, this.UpdateSlotOperationCompleted, userState);
        }
        
        private void OnUpdateSlotOperationCompleted(object arg) {
            if ((this.UpdateSlotCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateSlotCompleted(this, new UpdateSlotCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("UserCredentialsValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConfirmSlot", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int ConfirmSlot(int bId, string userName, decimal paidAmount) {
            object[] results = this.Invoke("ConfirmSlot", new object[] {
                        bId,
                        userName,
                        paidAmount});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void ConfirmSlotAsync(int bId, string userName, decimal paidAmount) {
            this.ConfirmSlotAsync(bId, userName, paidAmount, null);
        }
        
        /// <remarks/>
        public void ConfirmSlotAsync(int bId, string userName, decimal paidAmount, object userState) {
            if ((this.ConfirmSlotOperationCompleted == null)) {
                this.ConfirmSlotOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConfirmSlotOperationCompleted);
            }
            this.InvokeAsync("ConfirmSlot", new object[] {
                        bId,
                        userName,
                        paidAmount}, this.ConfirmSlotOperationCompleted, userState);
        }
        
        private void OnConfirmSlotOperationCompleted(object arg) {
            if ((this.ConfirmSlotCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConfirmSlotCompleted(this, new ConfirmSlotCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("UserCredentialsValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteSlot", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int DeleteSlot(int bookId) {
            object[] results = this.Invoke("DeleteSlot", new object[] {
                        bookId});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteSlotAsync(int bookId) {
            this.DeleteSlotAsync(bookId, null);
        }
        
        /// <remarks/>
        public void DeleteSlotAsync(int bookId, object userState) {
            if ((this.DeleteSlotOperationCompleted == null)) {
                this.DeleteSlotOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteSlotOperationCompleted);
            }
            this.InvokeAsync("DeleteSlot", new object[] {
                        bookId}, this.DeleteSlotOperationCompleted, userState);
        }
        
        private void OnDeleteSlotOperationCompleted(object arg) {
            if ((this.DeleteSlotCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteSlotCompleted(this, new DeleteSlotCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class UserCredentials : System.Web.Services.Protocols.SoapHeader {
        
        private string userNameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetCarRentalsCompletedEventHandler(object sender, GetCarRentalsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCarRentalsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCarRentalsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetCarCompletedEventHandler(object sender, GetCarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAvailableCarsCompletedEventHandler(object sender, GetAvailableCarsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAvailableCarsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAvailableCarsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void BookCarCompletedEventHandler(object sender, BookCarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BookCarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BookCarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetBookedCarsCompletedEventHandler(object sender, GetBookedCarsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBookedCarsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetBookedCarsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void UpdateSlotCompletedEventHandler(object sender, UpdateSlotCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateSlotCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateSlotCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ConfirmSlotCompletedEventHandler(object sender, ConfirmSlotCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConfirmSlotCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConfirmSlotCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DeleteSlotCompletedEventHandler(object sender, DeleteSlotCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteSlotCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteSlotCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591