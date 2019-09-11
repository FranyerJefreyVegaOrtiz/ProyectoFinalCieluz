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
            
            //var Foto = "FotoPro";
            //var Nombre = "NombrePro";
            //var Precio ="PrecioPro";
            if (Request.Params["IdProducto"] != null)
            {
                string Valor = Request.Params["IdProducto"];
                txtRecive.Text = Valor;
                int IdProduto = int.Parse(txtRecive.Text);
                DataSet dsProductos = new DataSet();
                dsProductos = miservice.mtdListarProWeb2(IdProduto);
                DataTable tblProducto = dsProductos.Tables["tblDatos"];
                imgFoto.ImageUrl = "data:image/jpg;base64," + tblProducto.Rows[0][0].ToString();
                Nombre.Text = tblProducto.Rows[0][1].ToString();
                Precio.Text = tblProducto.Rows[0][2].ToString();
            }
        }
        public void mtdRegistrarPedido()
        {

            try
            {
                 ServicioWebCieluz.clPedido objPedido = new ServicioWebCieluz.clPedido();
            objPedido.idProducto = int.Parse(txtRecive.Text);
            objPedido.Cantidad = int.Parse(txtCantidad.Text);
            objPedido.Talla = int.Parse(txtTalla.Text);
            objPedido.PrecioTotal = int.Parse(txtPrecioTotal.Text);
            objPedido.TipoPago = txtTipoPago.Text;
            objPedido.idCliente = 1;

            int resultado = miservice.mtdRegistrarPedido(objPedido);

            if (resultado > 0)
            {
                Response.Redirect("Index.aspx");
            }
            else
            {
                
            }
            }
            catch (Exception)
            {

                throw;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Correo"] != null)
            {
                mtdRegistrarPedido();
            }
            else
            {
                Response.Redirect("login.html");
            }
            
        }
    }
}