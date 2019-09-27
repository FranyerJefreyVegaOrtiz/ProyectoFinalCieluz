using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace appEscritorioCieluz
{
    public partial class Despachados : Form
    {
        servicioEscritorioCieluz.ServidorProyectoSoapClient miServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();
        public Despachados()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void mtdCargarDatos()
        {
            DataSet dsPedidos = new DataSet();
            dsPedidos = miServicio.mtdDespachadosEscritorio();
            DataTable tblPedido = dsPedidos.Tables["tblDatos"];
            dgvDespachados.DataSource = tblPedido;
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Despachados_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }

        private void btnEnviarCL_Click(object sender, EventArgs e)
        {
            servicioEscritorioCieluz.clPedidos objPedidos = new servicioEscritorioCieluz.clPedidos();

            int IdPedidos = int.Parse(txtId.Text);
            objPedidos.Estado = txtEstado.Text;
            objPedidos.Cantidad = txtCantidad.Text;
            objPedidos.Talla = txtTalla.Text;
            objPedidos.PrecioTotal = txtPrecioTotal.Text;
            objPedidos.TipoPago = txtTipoPago.Text;
            objPedidos.Estado = txtEstado.Text;
            objPedidos.IdCliente = int.Parse(txtIdCliente.Text);
            objPedidos.IdProducto = int.Parse(txtIdProducto.Text);

            int resultado = miServicio.mtdEditarPedido(objPedidos, IdPedidos);
            if (resultado > 0)
            {
                MessageBox.Show("Editado");
                mtdCargarDatos();
            }
            else
            {
                MessageBox.Show("No Se Puede Editar");
            }
        }

        int renglon;
        private void dgvDespachados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDespachados.SelectedCells.Count > 0)
                {
                    renglon = e.RowIndex;
                    string IdPedidos;
                    string Cantidad;
                    string Talla;
                    string PrecioTotal;
                    string TipoPago;
                    string Estado;
                    string IdCliente;
                    string IdProducto;


                    //Foto = dgvPedidos.Rows[renglon].Cells["Foto"].Value.ToString();
                    //dgvPedidos.Columns["Foto"].ReadOnly = true;
                    //string archivoBase64 = "Foto";
                    //byte[] archivoByte = Convert.FromBase64String(archivoBase64);
                    //File.WriteAllBytes(pbxImagen.Image.ToString(), archivoByte);
                    IdPedidos = dgvDespachados.Rows[renglon].Cells["IdPedidos"].Value.ToString();
                    dgvDespachados.Columns["IdPedidos"].ReadOnly = true;
                    txtId.Text = IdPedidos;

                    Cantidad = dgvDespachados.Rows[renglon].Cells["Cantidad"].Value.ToString();
                    dgvDespachados.Columns["Cantidad"].ReadOnly = true;
                    txtCantidad.Text = Cantidad;

                    Talla = dgvDespachados.Rows[renglon].Cells["Talla"].Value.ToString();
                    dgvDespachados.Columns["Talla"].ReadOnly = true;
                    txtTalla.Text = Talla;

                    PrecioTotal = dgvDespachados.Rows[renglon].Cells["PrecioTotal"].Value.ToString();
                    dgvDespachados.Columns["PrecioTotal"].ReadOnly = true;
                    txtPrecioTotal.Text = PrecioTotal;

                    TipoPago = dgvDespachados.Rows[renglon].Cells["TipoPago"].Value.ToString();
                    dgvDespachados.Columns["TipoPago"].ReadOnly = true;
                    txtTipoPago.Text = TipoPago;

                    IdCliente = dgvDespachados.Rows[renglon].Cells["IdCliente"].Value.ToString();
                    dgvDespachados.Columns["IdCliente"].ReadOnly = true;
                    txtIdCliente.Text = IdCliente;

                    IdProducto = dgvDespachados.Rows[renglon].Cells["IdProducto"].Value.ToString();
                    dgvDespachados.Columns["IdProducto"].ReadOnly = true;
                    txtIdProducto.Text = IdProducto;
                }
            }
            catch
            {
            }
        }
    }

}
