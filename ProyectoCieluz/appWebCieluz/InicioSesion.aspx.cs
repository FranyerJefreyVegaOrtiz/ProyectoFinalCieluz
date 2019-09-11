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
            ServicioWebCieluz.clCliente objCliente = new ServicioWebCieluz.clCliente();
            string Correo = Request.Form["Correo"];
            string Clave = Request.Form["Clave"];
            int IdCliente = 1;
            
            DataSet dsCliente = new DataSet();
            dsCliente = miservice.mtdListarClientes(IdCliente);
            DataTable tblLogin = dsCliente.Tables["tblDatos"];
            string IdCliente1 = tblLogin.Rows[0][0].ToString();
            dsCliente = miservice.mtdLoginWeb(Correo, Clave);
            Session["IdCliente"] = IdCliente1;
            if (tblLogin.Rows.Count >= 1)
            {
                Session["Correo"] = Correo;
                Application["Validar"] = 1;
                Response.Redirect("Index.aspx");
            }
            else
            {
                lblMensaje.Text = "Error al ingresar...";
            }
            Response.Redirect("Default.aspx?valor=" + IdCliente1);
        }
    }
}