﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appEscritorioCieluz.servicioEscritorioCieluz {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="servicioEscritorioCieluz.ServidorProyectoSoap")]
    public interface ServidorProyectoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarClientes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdRegistrarClientes(appEscritorioCieluz.servicioEscritorioCieluz.clCliente ObjCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarClientes", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdRegistrarClientesAsync(appEscritorioCieluz.servicioEscritorioCieluz.clCliente ObjCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarClientes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarClientes(string Correo, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarClientes", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarClientesAsync(string Correo, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdLoginEscritorio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdLoginEscritorio(string Correo, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdLoginEscritorio", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdLoginEscritorioAsync(string Correo, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdRegistrarProducto(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdRegistrarProductoAsync(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdEditarProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdEditarProducto(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdEditarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdEditarProductoAsync(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdEliminarProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdEliminarProducto(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdEliminarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdEliminarProductoAsync(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarAdmin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarAdmin(appEscritorioCieluz.servicioEscritorioCieluz.clAdministrador ObjAdmin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarAdmin", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarAdminAsync(appEscritorioCieluz.servicioEscritorioCieluz.clAdministrador ObjAdmin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarPro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarPro(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarPro", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarProAsync(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarProEscritorio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarProEscritorio();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarProEscritorio", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarProEscritorioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarProWeb", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarProWeb();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarProWeb", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarProWebAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarProWeb2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarProWeb2(int IdProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarProWeb2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarProWeb2Async(int IdProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarCli", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarCli();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarCli", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarCliAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarPed", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarPed();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarPed", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarPedAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clCliente : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idClienteField;
        
        private string tipoDocumentoField;
        
        private string documentoField;
        
        private string nombreField;
        
        private string apellidoField;
        
        private string telefonoField;
        
        private string correoField;
        
        private string departamentoField;
        
        private string municipioField;
        
        private string direccionField;
        
        private string claveField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int IdCliente {
            get {
                return this.idClienteField;
            }
            set {
                this.idClienteField = value;
                this.RaisePropertyChanged("IdCliente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string TipoDocumento {
            get {
                return this.tipoDocumentoField;
            }
            set {
                this.tipoDocumentoField = value;
                this.RaisePropertyChanged("TipoDocumento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Documento {
            get {
                return this.documentoField;
            }
            set {
                this.documentoField = value;
                this.RaisePropertyChanged("Documento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("Apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("Telefono");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("Correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Departamento {
            get {
                return this.departamentoField;
            }
            set {
                this.departamentoField = value;
                this.RaisePropertyChanged("Departamento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Municipio {
            get {
                return this.municipioField;
            }
            set {
                this.municipioField = value;
                this.RaisePropertyChanged("Municipio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("Direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Clave {
            get {
                return this.claveField;
            }
            set {
                this.claveField = value;
                this.RaisePropertyChanged("Clave");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clAdministrador : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idAdministradorField;
        
        private string documentoField;
        
        private string nombreField;
        
        private string apellidoField;
        
        private string telefonoField;
        
        private string correoField;
        
        private string claveField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int IdAdministrador {
            get {
                return this.idAdministradorField;
            }
            set {
                this.idAdministradorField = value;
                this.RaisePropertyChanged("IdAdministrador");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Documento {
            get {
                return this.documentoField;
            }
            set {
                this.documentoField = value;
                this.RaisePropertyChanged("Documento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("Apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("Telefono");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("Correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Clave {
            get {
                return this.claveField;
            }
            set {
                this.claveField = value;
                this.RaisePropertyChanged("Clave");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clProducto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idProductoField;
        
        private string nombreField;
        
        private string codigoField;
        
        private string fotoField;
        
        private string precioField;
        
        private string colorField;
        
        private string diseñoField;
        
        private string descripcionField;
        
        private int idAdministradorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int IdProducto {
            get {
                return this.idProductoField;
            }
            set {
                this.idProductoField = value;
                this.RaisePropertyChanged("IdProducto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("Codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Foto {
            get {
                return this.fotoField;
            }
            set {
                this.fotoField = value;
                this.RaisePropertyChanged("Foto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Precio {
            get {
                return this.precioField;
            }
            set {
                this.precioField = value;
                this.RaisePropertyChanged("Precio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
                this.RaisePropertyChanged("Color");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Diseño {
            get {
                return this.diseñoField;
            }
            set {
                this.diseñoField = value;
                this.RaisePropertyChanged("Diseño");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("Descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int idAdministrador {
            get {
                return this.idAdministradorField;
            }
            set {
                this.idAdministradorField = value;
                this.RaisePropertyChanged("idAdministrador");
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
    public interface ServidorProyectoSoapChannel : appEscritorioCieluz.servicioEscritorioCieluz.ServidorProyectoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServidorProyectoSoapClient : System.ServiceModel.ClientBase<appEscritorioCieluz.servicioEscritorioCieluz.ServidorProyectoSoap>, appEscritorioCieluz.servicioEscritorioCieluz.ServidorProyectoSoap {
        
        public ServidorProyectoSoapClient() {
        }
        
        public ServidorProyectoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServidorProyectoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServidorProyectoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServidorProyectoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int mtdRegistrarClientes(appEscritorioCieluz.servicioEscritorioCieluz.clCliente ObjCliente) {
            return base.Channel.mtdRegistrarClientes(ObjCliente);
        }
        
        public System.Threading.Tasks.Task<int> mtdRegistrarClientesAsync(appEscritorioCieluz.servicioEscritorioCieluz.clCliente ObjCliente) {
            return base.Channel.mtdRegistrarClientesAsync(ObjCliente);
        }
        
        public System.Data.DataSet mtdListarClientes(string Correo, string Clave) {
            return base.Channel.mtdListarClientes(Correo, Clave);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarClientesAsync(string Correo, string Clave) {
            return base.Channel.mtdListarClientesAsync(Correo, Clave);
        }
        
        public System.Data.DataSet mtdLoginEscritorio(string Correo, string Clave) {
            return base.Channel.mtdLoginEscritorio(Correo, Clave);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdLoginEscritorioAsync(string Correo, string Clave) {
            return base.Channel.mtdLoginEscritorioAsync(Correo, Clave);
        }
        
        public int mtdRegistrarProducto(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro) {
            return base.Channel.mtdRegistrarProducto(objPro);
        }
        
        public System.Threading.Tasks.Task<int> mtdRegistrarProductoAsync(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro) {
            return base.Channel.mtdRegistrarProductoAsync(objPro);
        }
        
        public int mtdEditarProducto(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro) {
            return base.Channel.mtdEditarProducto(objPro);
        }
        
        public System.Threading.Tasks.Task<int> mtdEditarProductoAsync(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro) {
            return base.Channel.mtdEditarProductoAsync(objPro);
        }
        
        public int mtdEliminarProducto(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro) {
            return base.Channel.mtdEliminarProducto(objPro);
        }
        
        public System.Threading.Tasks.Task<int> mtdEliminarProductoAsync(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objPro) {
            return base.Channel.mtdEliminarProductoAsync(objPro);
        }
        
        public System.Data.DataSet mtdListarAdmin(appEscritorioCieluz.servicioEscritorioCieluz.clAdministrador ObjAdmin) {
            return base.Channel.mtdListarAdmin(ObjAdmin);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarAdminAsync(appEscritorioCieluz.servicioEscritorioCieluz.clAdministrador ObjAdmin) {
            return base.Channel.mtdListarAdminAsync(ObjAdmin);
        }
        
        public System.Data.DataSet mtdListarPro(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objProducto) {
            return base.Channel.mtdListarPro(objProducto);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarProAsync(appEscritorioCieluz.servicioEscritorioCieluz.clProducto objProducto) {
            return base.Channel.mtdListarProAsync(objProducto);
        }
        
        public System.Data.DataSet mtdListarProEscritorio() {
            return base.Channel.mtdListarProEscritorio();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarProEscritorioAsync() {
            return base.Channel.mtdListarProEscritorioAsync();
        }
        
        public System.Data.DataSet mtdListarProWeb() {
            return base.Channel.mtdListarProWeb();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarProWebAsync() {
            return base.Channel.mtdListarProWebAsync();
        }
        
        public System.Data.DataSet mtdListarProWeb2(int IdProducto) {
            return base.Channel.mtdListarProWeb2(IdProducto);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarProWeb2Async(int IdProducto) {
            return base.Channel.mtdListarProWeb2Async(IdProducto);
        }
        
        public System.Data.DataSet mtdListarCli() {
            return base.Channel.mtdListarCli();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarCliAsync() {
            return base.Channel.mtdListarCliAsync();
        }
        
        public System.Data.DataSet mtdListarPed() {
            return base.Channel.mtdListarPed();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarPedAsync() {
            return base.Channel.mtdListarPedAsync();
        }
    }
}
