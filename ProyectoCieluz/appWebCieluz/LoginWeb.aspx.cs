using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebCieluz
{
    public partial class Formulario_web25 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void mtdVaciar()
        {
            txtCorreo.Text = "";
            txtClave.Text = "";
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            ServicioWebCieluz.ServidorProyectoSoapClient miServicio = new ServicioWebCieluz.ServidorProyectoSoapClient();
            string Correo = txtCorreo.Text;
            string Clave = txtClave.Text;

            DataSet dsLogin = new DataSet();
            dsLogin = miServicio.mtdLoginWeb(Correo, Clave);
            DataTable TablaLogin = dsLogin.Tables["tblDatos"];
            if (TablaLogin.Rows.Count>0)
            {
                Session["Correo"] = Correo;
                Session["IdCliente"] = TablaLogin.Rows[0][0].ToString();
                Response.Redirect("index.html");
            }
            else
            {
                mtdVaciar();
            }
        }
    }
}