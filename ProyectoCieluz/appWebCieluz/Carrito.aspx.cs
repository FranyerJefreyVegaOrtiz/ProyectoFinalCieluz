using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebCieluz
{
    public partial class Formulario_web24 : System.Web.UI.Page
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
            LblPrecio.Text = tblProducto.Rows[0][2].ToString();
        }
    }
}