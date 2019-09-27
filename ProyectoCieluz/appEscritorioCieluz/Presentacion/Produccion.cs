using ServidorProyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEscritorioCieluz.Presentacion
{
    public partial class Produccion : Form
    {
        public Produccion()
        {
            InitializeComponent();
        }

        public void mtdCargarDatos()
        {
            DataSet dsPedidos = new DataSet();
            dsPedidos = miServicio.mtdProduccionEscritorio();
            DataTable tblPedido = dsPedidos.Tables["tblDatos"];
            dgvProduccion.DataSource = tblPedido;
        }

        servicioEscritorioCieluz.ServidorProyectoSoapClient miServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            servicioEscritorioCieluz.clPedidos objPedidos = new servicioEscritorioCieluz.clPedidos();

        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
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
        private void dgvProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProduccion.SelectedCells.Count > 0)
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
                    IdPedidos = dgvProduccion.Rows[renglon].Cells["IdPedidos"].Value.ToString();
                    dgvProduccion.Columns["IdPedidos"].ReadOnly = true;
                    txtId.Text = IdPedidos;

                    Cantidad = dgvProduccion.Rows[renglon].Cells["Cantidad"].Value.ToString();
                    dgvProduccion.Columns["Cantidad"].ReadOnly = true;
                    txtCantidad.Text = Cantidad;

                    Talla = dgvProduccion.Rows[renglon].Cells["Talla"].Value.ToString();
                    dgvProduccion.Columns["Talla"].ReadOnly = true;
                    txtTalla.Text = Talla;

                    PrecioTotal = dgvProduccion.Rows[renglon].Cells["PrecioTotal"].Value.ToString();
                    dgvProduccion.Columns["PrecioTotal"].ReadOnly = true;
                    txtPrecioTotal.Text = PrecioTotal;

                    TipoPago = dgvProduccion.Rows[renglon].Cells["TipoPago"].Value.ToString();
                    dgvProduccion.Columns["TipoPago"].ReadOnly = true;
                    txtTipoPago.Text = TipoPago;
                    
                    IdCliente = dgvProduccion.Rows[renglon].Cells["IdCliente"].Value.ToString();
                    dgvProduccion.Columns["IdCliente"].ReadOnly = true;
                    txtIdCliente.Text = IdCliente;

                    IdProducto = dgvProduccion.Rows[renglon].Cells["IdProducto"].Value.ToString();
                    dgvProduccion.Columns["IdProducto"].ReadOnly = true;
                    txtIdProducto.Text = IdProducto;
                }
            }
            catch
            {
            }
        }
    }
}
