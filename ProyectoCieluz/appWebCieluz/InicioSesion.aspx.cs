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
            int IdCliente = 1;

            ServicioWebCieluz.clCliente objCliente = new ServicioWebCieluz.clCliente();
            DataSet dsCliente = new DataSet();
            dsCliente = miservice.mtdLoginWeb(IdCliente,Correo, Clave);
            DataTable tblLogin = dsCliente.Tables["tblDatos"];
            IdCliente = int.Parse(tblLogin.Rows[0][0].ToString());
            if (tblLogin.Rows.Count > 0)
            {
                Session["Correo"] = Correo;

                Session["IdUsuario"] = IdCliente;
                Application["Validar"] = 1;
                Response.Redirect("Index.aspx");
            }
            else
            {
                lblMensaje.Text = "Error al ingresar...";
            }
        }
    }
}