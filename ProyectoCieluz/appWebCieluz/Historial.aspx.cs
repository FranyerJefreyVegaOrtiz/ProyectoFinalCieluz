using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebCieluz
{
    public partial class Formulario_web26 : System.Web.UI.Page
    {

        ServicioWebCieluz.clProducto objProducto = new ServicioWebCieluz.clProducto();

        ServicioWebCieluz.ServidorProyectoSoapClient miservice = new ServicioWebCieluz.ServidorProyectoSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            mtdCargarPto();
        }

        protected void mtdCargarPto()
        {
            try
            {
                ServicioWebCieluz.clProducto objProducto = new ServicioWebCieluz.clProducto();
                DataSet dsProducto = new DataSet();
                dsProducto = miservice.mtdListarProWeb();
                DataTable tblProducto = dsProducto.Tables["tblDatos"];

                Repeater1.DataSource = tblProducto;
                Repeater1.DataBind();
            }
            catch
            {

            }
        }
        public System.Drawing.Image RedimencionarImagen(System.Drawing.Image ImagenOriginal, int Alto)
        {
            var Radio = (double)Alto / ImagenOriginal.Height;
            var NuevoAncho = (int)(ImagenOriginal.Width * Radio);
            var NuevoAlto = (int)(ImagenOriginal.Height * Radio);
            var NuevaImagenRedimencional = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimencional);
            g.DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimencional;
        }
    }
}