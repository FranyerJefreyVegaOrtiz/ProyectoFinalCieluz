using ServidorProyecto.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebCieluz
{
    public partial class Formulario_web2 : System.Web.UI.Page
    {
        ServicioWebCieluz.clProducto objProducto = new ServicioWebCieluz.clProducto();

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
            try
            {

                ServicioWebCieluz.clProducto objProducto = new ServicioWebCieluz.clProducto();
                DataSet dsProducto = new DataSet();
                dsProducto = miservice.mtdListarProWeb();
                DataTable tblProducto = dsProducto.Tables["tblDatos"];
                //var dato = tblProducto.Rows[0][3];
                //dato = Session["IdProducto"].ToString();
                //tblProducto.Rows[0]["imgSalida"] = dato;
                //Response.Redirect("DetalleProductos.aspx" + dato);
                // Image1.ImageUrl = "data:image/jpg;base64," + tblProducto.Rows[0][0].ToString();

                Repeater1.DataSource = tblProducto;
                Repeater1.DataBind();
            }
            catch
            {

            }
        }
        public System.Drawing.Image RedimencionarImagen (System.Drawing.Image ImagenOriginal, int Alto)
        {
            var Radio = (double)Alto / ImagenOriginal.Height;
            var NuevoAncho = (int)(ImagenOriginal.Width * Radio);
            var NuevoAlto = (int)(ImagenOriginal.Height * Radio);
            var NuevaImagenRedimencional = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimencional);
            g.DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimencional;
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
        }

        protected void btnTodos_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarDTodosProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnSencillas_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarDSencillasProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnAnimales_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarDAnimalesProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnFlores_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarDFloresProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnPersonajes_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarDPersonajesProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnEspecial_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarDEspecialProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnTodosColor_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCTodosProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnAmarillo_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCAmarilloProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnAzul_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCAzulProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnBlanco_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCBlancoProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnCafé_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCCafeProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnGris_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCGrisProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnNaranja_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCNaranjaProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnNegro_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCNegroProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnVerde_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCVerdeProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnRojo_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCRojoProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnMorado_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCMoradoProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }

        protected void btnRosado_Click(object sender, EventArgs e)
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miservice.mtdListarCRosadoProWeb();
            DataTable tblProducto = dsProducto.Tables["tblDatos"];

            Repeater1.DataSource = tblProducto;
            Repeater1.DataBind();
        }
    }
}