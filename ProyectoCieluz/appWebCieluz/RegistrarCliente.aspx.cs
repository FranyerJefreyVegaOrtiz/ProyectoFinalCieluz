using appEscritorioCieluz;
using ServidorProyecto.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace appWebCieluz
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        ServicioWebCieluz.ServidorProyectoSoapClient Servicio = new ServicioWebCieluz.ServidorProyectoSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioWebCieluz.clCliente objClientes = new ServicioWebCieluz.clCliente();
            string Tipo = Request.Form["Tipo"];
            string Documento = Request.Form["Documento"];
            string Nombre = Request.Form["Nombre"];
            string Apellido = Request.Form["Apellido"];
            string Telefono = Request.Form["Telefono"];
            string Correo = Request.Form["Correo"];
            string Departamento = Request.Form["Departamento"];
            string Municipio = Request.Form["Municipio"];
            string Direccion = Request.Form["Direccion"];
            string Clave = Request.Form["Clave"];
            string contraseña = Request.Form["password"];
            objClientes.TipoDocumento = Tipo;
            objClientes.Documento = Documento;
            objClientes.Nombre = Nombre;
            objClientes.Apellido = Apellido;
            objClientes.Telefono =Telefono;
            objClientes.Correo = Correo;
            objClientes.Departamento = Departamento;
            objClientes.Municipio = Municipio;
            objClientes.Direccion = Direccion;
            objClientes.Clave = Clave;

            int resultado = Servicio.mtdRegistrarClientes(objClientes);

            if (resultado > 0)
            {

            }


        }



    }
}