using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebCieluz
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {

        protected void Page_Init(object sender, EventArgs e)

        {
           // Correo.Text = Session["Correo"].ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
          //  var dato = Session["Correo"].ToString();

            if (Session["Correo"]!=null)
            {
                Correo.Text = Session["Correo"].ToString();
            }
        }
    }
}