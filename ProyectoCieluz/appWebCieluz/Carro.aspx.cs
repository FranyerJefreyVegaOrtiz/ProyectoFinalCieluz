using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace appWebCieluz
{
    public partial class Formulario_web24 : System.Web.UI.Page
    {
        
        ServicioWebCieluz.ServidorProyectoSoapClient miservice = new ServicioWebCieluz.ServidorProyectoSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblIdCliente.Text = Session["IdCliente"].ToString();

            
            
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

            ServicioWebCieluz.clPedidos objPedidos = new ServicioWebCieluz.clPedidos();
            objPedidos.IdProducto = int.Parse(txtRecive.Text);
            objPedidos.Cantidad = txtCantidad.Text;
            objPedidos.Talla = txtTalla.Text;
            objPedidos.PrecioTotal = lblTotal.Text;
            objPedidos.TipoPago = cmbTipo.SelectedValue;
            objPedidos.IdCliente = int.Parse(lblIdCliente.Text);

            int resultado = miservice.mtdRegistrarPedido(objPedidos);

            if (resultado > 0)
            {

            }
            else
            {
                
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

        protected void btnOperacion_Click(object sender, EventArgs e)
        {
            int pre = int.Parse(Precio.Text);
            int can = int.Parse(txtCantidad.Text);
            int valor = pre * can;
            lblTotal.Text = valor.ToString();

        }

        protected void btnCompra_Click(object sender, EventArgs e)
        {
            mtdRegistrarPedido();
            try
            {

                txtFrom.Text = "Calzadocieluz@gmail.com";
                txtClave.Text = "Cieluz-2019";
                txtSubject.Text = "Tu Pedido - Calzado Cieluz";
                txtBody.Text = "Tu pedido se esta creando...";
                if (Session["Correo"] != null)
                {
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress(txtFrom.Text);
                    msg.To.Add(Session["Correo"].ToString());
                    msg.Subject = txtSubject.Text;
                    msg.Body = txtBody.Text;
                    SmtpClient sc = new SmtpClient("smtp.gmail.com");
                    sc.Port = 25;
                    sc.Credentials = new NetworkCredential(txtFrom.Text, txtClave.Text);
                    sc.EnableSsl = true;
                    sc.Send(msg);
                    
                    Response.Redirect("confirmation.html");

                }
                else
                {
                    Response.Redirect("login.html");
                }

            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Conexion; Hubo un error en la conexion');" , true);
            }
           
        }
    }
}