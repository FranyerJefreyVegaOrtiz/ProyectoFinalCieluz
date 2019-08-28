using ServidorProyecto.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            string Nombre = Request.Form["Nombre"];
            string Precio = Request.Form["Precio"];
            ServicioWebCieluz.clProducto objCliente = new ServicioWebCieluz.clProducto();
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarPro(Nombre, Precio);
            DataTable  tblPro = dsProducto.Tables["tblDatos"];

            if (tblPro.Rows.Count > 0)
            {
                clProducto prop = new clProducto();
                prop.Nombre = Convert.ToString(tblPro.Rows[Nombre.Length]);
                prop.Precio = Convert.ToString(tblPro.Rows[Precio.Length]);

            }
        }
    }
}