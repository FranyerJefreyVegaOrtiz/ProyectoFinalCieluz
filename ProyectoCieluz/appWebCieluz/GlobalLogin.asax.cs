using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace appWebCieluz
{
    public class GlobalLogin : System.Web.HttpApplication
    {
        ServicioWebCieluz.clCliente servi = new ServicioWebCieluz.clCliente();
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            ServicioWebCieluz.clCliente objCliente = new ServicioWebCieluz.clCliente();
            Session["Correo"] = objCliente.Correo;
            Session["Clave"] = objCliente.Clave;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}