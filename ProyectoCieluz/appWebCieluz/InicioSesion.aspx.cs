using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;

namespace appWebCieluz
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        ServicioWebCieluz.ServidorProyectoSoapClient miservice = new ServicioWebCieluz.ServidorProyectoSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            string Correo = Request.Form["Correo"];
            string Clave = Request.Form["Clave"];

            ServicioWebCieluz.clCliente objCliente = new ServicioWebCieluz.clCliente();
            DataSet dsCliente = new DataSet();
            dsCliente = miservice.mtdLoginWeb(Correo, Clave);
            DataTable tblLogin = dsCliente.Tables["tblDatos"];

            if (tblLogin.Rows.Count > 0)
            {
                Session["Correo"] = Correo;
                Session["IdUsuario"] = tblLogin.Rows[0][0].ToString();
                Response.Redirect("index.html");
            }
            else
            {
                lblMensaje.Text = "Error al ingresar...";
            }
        }
    }
}