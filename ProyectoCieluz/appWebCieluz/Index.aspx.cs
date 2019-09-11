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
        ServicioWebCieluz.ServidorProyectoSoapClient miservice = new ServicioWebCieluz.ServidorProyectoSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           //string Correo= Request.Form["Correo1"];
           //// string IdCliente = Request.Form["IdCliente"];
           //// //string Correo = Request.Form["Correo"];

           //// //ServicioWebCieluz.clCliente objCliente = new ServicioWebCieluz.clCliente();
           //// //string Valor = Request.QueryString["IdCliente"];
           //// //txtRecive.Text = Valor;
           //// //int IdCliente = int.Parse(txtRecive.Text);
           //// //DataSet dsCliente = new DataSet();
           //// //dsCliente = miservice.mtdIndex(IdCliente);
           //// //DataTable tblCliente = dsCliente.Tables["tblDatos"];
           //// //Session["Correo"] = Correo;
           //// //Session["IdUsuario"] = tblCliente.Rows[0][0].ToString();

           //Correo = Session["Correo"].ToString();
           // IdCliente = Session["IdCliente"].ToString();
        }
    }
}