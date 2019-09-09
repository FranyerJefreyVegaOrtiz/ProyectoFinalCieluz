using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace appWebCieluz
{
    public partial class Formulario_web23 : System.Web.UI.Page
    {
        ServicioWebCieluz.ServidorProyectoSoapClient miservice = new ServicioWebCieluz.ServidorProyectoSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioWebCieluz.clProducto objProducto = new ServicioWebCieluz.clProducto();
            string Valor = Request.QueryString["IdProducto"];
            txtRecive.Text = Valor;
            int IdProduto = int.Parse(txtRecive.Text);
            DataSet dsProductos = new DataSet();
            dsProductos = miservice.mtdListarProWeb2(IdProduto);
            DataTable tblProducto = dsProductos.Tables["tblDatos"];
            ImgProducto.ImageUrl = "data:image/jpg;base64," + tblProducto.Rows[0][0].ToString();
            lblNombre.Text = tblProducto.Rows[0][1].ToString();
            lblColor.Text = tblProducto.Rows[0][5].ToString();
            lblPrecio.Text = tblProducto.Rows[0][2].ToString();
            lblDescripcion.Text = tblProducto.Rows[0][4].ToString();
            lblDiseño.Text = tblProducto.Rows[0][6].ToString();

        }

        protected void btnCarro_Click(object sender, EventArgs e)
        {
                Response.Redirect("Carro.aspx?IdProducto=" + txtRecive.Text);
        }
    }
}