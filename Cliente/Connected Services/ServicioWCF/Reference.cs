﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente.ServicioWCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="cEmpleado", Namespace="http://schemas.datacontract.org/2004/07/ServicioWCF")]
    [System.SerializableAttribute()]
    public partial class cEmpleado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CedulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cedula {
            get {
                return this.CedulaField;
            }
            set {
                if ((this.CedulaField.Equals(value) != true)) {
                    this.CedulaField = value;
                    this.RaisePropertyChanged("Cedula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioWCF.IServicioWCF")]
    public interface IServicioWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/LoginEmpleado", ReplyAction="http://tempuri.org/IServicioWCF/LoginEmpleadoResponse")]
        Cliente.ServicioWCF.cEmpleado LoginEmpleado(int ced, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/LoginEmpleado", ReplyAction="http://tempuri.org/IServicioWCF/LoginEmpleadoResponse")]
        System.Threading.Tasks.Task<Cliente.ServicioWCF.cEmpleado> LoginEmpleadoAsync(int ced, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/CrearEmpleado", ReplyAction="http://tempuri.org/IServicioWCF/CrearEmpleadoResponse")]
        string CrearEmpleado(int ced, string nombre, string apellido, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/CrearEmpleado", ReplyAction="http://tempuri.org/IServicioWCF/CrearEmpleadoResponse")]
        System.Threading.Tasks.Task<string> CrearEmpleadoAsync(int ced, string nombre, string apellido, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/GetEmpleado", ReplyAction="http://tempuri.org/IServicioWCF/GetEmpleadoResponse")]
        Cliente.ServicioWCF.cEmpleado GetEmpleado(int ced);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/GetEmpleado", ReplyAction="http://tempuri.org/IServicioWCF/GetEmpleadoResponse")]
        System.Threading.Tasks.Task<Cliente.ServicioWCF.cEmpleado> GetEmpleadoAsync(int ced);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/VerificarCliente", ReplyAction="http://tempuri.org/IServicioWCF/VerificarClienteResponse")]
        bool VerificarCliente(int ced);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/VerificarCliente", ReplyAction="http://tempuri.org/IServicioWCF/VerificarClienteResponse")]
        System.Threading.Tasks.Task<bool> VerificarClienteAsync(int ced);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/ModificarEmpleado", ReplyAction="http://tempuri.org/IServicioWCF/ModificarEmpleadoResponse")]
        string ModificarEmpleado(int ced, int nueva_ced, string nombre, string apellido, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/ModificarEmpleado", ReplyAction="http://tempuri.org/IServicioWCF/ModificarEmpleadoResponse")]
        System.Threading.Tasks.Task<string> ModificarEmpleadoAsync(int ced, int nueva_ced, string nombre, string apellido, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/EliminarProducto", ReplyAction="http://tempuri.org/IServicioWCF/EliminarProductoResponse")]
        string EliminarProducto(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/EliminarProducto", ReplyAction="http://tempuri.org/IServicioWCF/EliminarProductoResponse")]
        System.Threading.Tasks.Task<string> EliminarProductoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/EliminarDeTabla", ReplyAction="http://tempuri.org/IServicioWCF/EliminarDeTablaResponse")]
        string EliminarDeTabla(int id, string tabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/EliminarDeTabla", ReplyAction="http://tempuri.org/IServicioWCF/EliminarDeTablaResponse")]
        System.Threading.Tasks.Task<string> EliminarDeTablaAsync(int id, string tabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AlterarProducto", ReplyAction="http://tempuri.org/IServicioWCF/AlterarProductoResponse")]
        string AlterarProducto(int id, string nombre, string descripcion, int precio, int cantidad, int proveedor, int tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AlterarProducto", ReplyAction="http://tempuri.org/IServicioWCF/AlterarProductoResponse")]
        System.Threading.Tasks.Task<string> AlterarProductoAsync(int id, string nombre, string descripcion, int precio, int cantidad, int proveedor, int tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AlterarProveedor", ReplyAction="http://tempuri.org/IServicioWCF/AlterarProveedorResponse")]
        string AlterarProveedor(int id, string nombre, string rif, string dir_fiscal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AlterarProveedor", ReplyAction="http://tempuri.org/IServicioWCF/AlterarProveedorResponse")]
        System.Threading.Tasks.Task<string> AlterarProveedorAsync(int id, string nombre, string rif, string dir_fiscal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AlterarCliente", ReplyAction="http://tempuri.org/IServicioWCF/AlterarClienteResponse")]
        string AlterarCliente(int id, int cedula, string nombre, string apellido, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AlterarCliente", ReplyAction="http://tempuri.org/IServicioWCF/AlterarClienteResponse")]
        System.Threading.Tasks.Task<string> AlterarClienteAsync(int id, int cedula, string nombre, string apellido, string telefono);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AlterarTipoProducto", ReplyAction="http://tempuri.org/IServicioWCF/AlterarTipoProductoResponse")]
        string AlterarTipoProducto(int id, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AlterarTipoProducto", ReplyAction="http://tempuri.org/IServicioWCF/AlterarTipoProductoResponse")]
        System.Threading.Tasks.Task<string> AlterarTipoProductoAsync(int id, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AgregarFactura", ReplyAction="http://tempuri.org/IServicioWCF/AgregarFacturaResponse")]
        string AgregarFactura(int cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AgregarFactura", ReplyAction="http://tempuri.org/IServicioWCF/AgregarFacturaResponse")]
        System.Threading.Tasks.Task<string> AgregarFacturaAsync(int cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AgregarDetalleFactura", ReplyAction="http://tempuri.org/IServicioWCF/AgregarDetalleFacturaResponse")]
        string AgregarDetalleFactura(int id, int id_producto, int cantidad, int precio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/AgregarDetalleFactura", ReplyAction="http://tempuri.org/IServicioWCF/AgregarDetalleFacturaResponse")]
        System.Threading.Tasks.Task<string> AgregarDetalleFacturaAsync(int id, int id_producto, int cantidad, int precio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/GetDataTable", ReplyAction="http://tempuri.org/IServicioWCF/GetDataTableResponse")]
        System.Data.DataTable GetDataTable(string tabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWCF/GetDataTable", ReplyAction="http://tempuri.org/IServicioWCF/GetDataTableResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDataTableAsync(string tabla);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioWCFChannel : Cliente.ServicioWCF.IServicioWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioWCFClient : System.ServiceModel.ClientBase<Cliente.ServicioWCF.IServicioWCF>, Cliente.ServicioWCF.IServicioWCF {
        
        public ServicioWCFClient() {
        }
        
        public ServicioWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Cliente.ServicioWCF.cEmpleado LoginEmpleado(int ced, string pwd) {
            return base.Channel.LoginEmpleado(ced, pwd);
        }
        
        public System.Threading.Tasks.Task<Cliente.ServicioWCF.cEmpleado> LoginEmpleadoAsync(int ced, string pwd) {
            return base.Channel.LoginEmpleadoAsync(ced, pwd);
        }
        
        public string CrearEmpleado(int ced, string nombre, string apellido, string pwd) {
            return base.Channel.CrearEmpleado(ced, nombre, apellido, pwd);
        }
        
        public System.Threading.Tasks.Task<string> CrearEmpleadoAsync(int ced, string nombre, string apellido, string pwd) {
            return base.Channel.CrearEmpleadoAsync(ced, nombre, apellido, pwd);
        }
        
        public Cliente.ServicioWCF.cEmpleado GetEmpleado(int ced) {
            return base.Channel.GetEmpleado(ced);
        }
        
        public System.Threading.Tasks.Task<Cliente.ServicioWCF.cEmpleado> GetEmpleadoAsync(int ced) {
            return base.Channel.GetEmpleadoAsync(ced);
        }
        
        public bool VerificarCliente(int ced) {
            return base.Channel.VerificarCliente(ced);
        }
        
        public System.Threading.Tasks.Task<bool> VerificarClienteAsync(int ced) {
            return base.Channel.VerificarClienteAsync(ced);
        }
        
        public string ModificarEmpleado(int ced, int nueva_ced, string nombre, string apellido, string pwd) {
            return base.Channel.ModificarEmpleado(ced, nueva_ced, nombre, apellido, pwd);
        }
        
        public System.Threading.Tasks.Task<string> ModificarEmpleadoAsync(int ced, int nueva_ced, string nombre, string apellido, string pwd) {
            return base.Channel.ModificarEmpleadoAsync(ced, nueva_ced, nombre, apellido, pwd);
        }
        
        public string EliminarProducto(int id) {
            return base.Channel.EliminarProducto(id);
        }
        
        public System.Threading.Tasks.Task<string> EliminarProductoAsync(int id) {
            return base.Channel.EliminarProductoAsync(id);
        }
        
        public string EliminarDeTabla(int id, string tabla) {
            return base.Channel.EliminarDeTabla(id, tabla);
        }
        
        public System.Threading.Tasks.Task<string> EliminarDeTablaAsync(int id, string tabla) {
            return base.Channel.EliminarDeTablaAsync(id, tabla);
        }
        
        public string AlterarProducto(int id, string nombre, string descripcion, int precio, int cantidad, int proveedor, int tipo) {
            return base.Channel.AlterarProducto(id, nombre, descripcion, precio, cantidad, proveedor, tipo);
        }
        
        public System.Threading.Tasks.Task<string> AlterarProductoAsync(int id, string nombre, string descripcion, int precio, int cantidad, int proveedor, int tipo) {
            return base.Channel.AlterarProductoAsync(id, nombre, descripcion, precio, cantidad, proveedor, tipo);
        }
        
        public string AlterarProveedor(int id, string nombre, string rif, string dir_fiscal) {
            return base.Channel.AlterarProveedor(id, nombre, rif, dir_fiscal);
        }
        
        public System.Threading.Tasks.Task<string> AlterarProveedorAsync(int id, string nombre, string rif, string dir_fiscal) {
            return base.Channel.AlterarProveedorAsync(id, nombre, rif, dir_fiscal);
        }
        
        public string AlterarCliente(int id, int cedula, string nombre, string apellido, string telefono) {
            return base.Channel.AlterarCliente(id, cedula, nombre, apellido, telefono);
        }
        
        public System.Threading.Tasks.Task<string> AlterarClienteAsync(int id, int cedula, string nombre, string apellido, string telefono) {
            return base.Channel.AlterarClienteAsync(id, cedula, nombre, apellido, telefono);
        }
        
        public string AlterarTipoProducto(int id, string descripcion) {
            return base.Channel.AlterarTipoProducto(id, descripcion);
        }
        
        public System.Threading.Tasks.Task<string> AlterarTipoProductoAsync(int id, string descripcion) {
            return base.Channel.AlterarTipoProductoAsync(id, descripcion);
        }
        
        public string AgregarFactura(int cedula) {
            return base.Channel.AgregarFactura(cedula);
        }
        
        public System.Threading.Tasks.Task<string> AgregarFacturaAsync(int cedula) {
            return base.Channel.AgregarFacturaAsync(cedula);
        }
        
        public string AgregarDetalleFactura(int id, int id_producto, int cantidad, int precio) {
            return base.Channel.AgregarDetalleFactura(id, id_producto, cantidad, precio);
        }
        
        public System.Threading.Tasks.Task<string> AgregarDetalleFacturaAsync(int id, int id_producto, int cantidad, int precio) {
            return base.Channel.AgregarDetalleFacturaAsync(id, id_producto, cantidad, precio);
        }
        
        public System.Data.DataTable GetDataTable(string tabla) {
            return base.Channel.GetDataTable(tabla);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDataTableAsync(string tabla) {
            return base.Channel.GetDataTableAsync(tabla);
        }
    }
}