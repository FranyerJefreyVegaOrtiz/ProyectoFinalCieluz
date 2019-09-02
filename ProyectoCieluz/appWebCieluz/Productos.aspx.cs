using ServidorProyecto.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebCieluz
{
    public partial class Formulario_web2 : System.Web.UI.Page
    {
        ServicioWebCieluz.ServidorProyectoSoapClient miservice = new ServicioWebCieluz.ServidorProyectoSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            mtdCargarPto();
            //string Nombre = Request.Form["Nombre"];
            ////string Precio = Request.Form["Precio"];

            //DataSet dsProductos = new DataSet();
            //dsProductos = miservice.mtdListarProWeb();
            //DataTable tblProductos = dsProductos.Tables["tblDatos"];
            //txtNombre.DataSource = tblProductos;
            //txtNombre.DataValueField = "Nombre";
            //txtNombre.DataTextField = "IdProducto";
            //txtNombre.DataBind();
        }
        protected void mtdCargarPto()
        {
            DataSet dsProucto = new DataSet();
            dsProucto = miservice.mtdListarProWeb();
            DataTable tblProducto = dsProucto.Tables["tblDatos"];


            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }
    }
}