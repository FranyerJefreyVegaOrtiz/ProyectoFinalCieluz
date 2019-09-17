using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEscritorioCieluz
{
    public partial class PedidosHoy : Form
    {
        public PedidosHoy()
        {
            InitializeComponent();
        }

        servicioEscritorioCieluz.ServidorProyectoSoapClient miServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();

        private void PedidosHoy_Load(object sender, EventArgs e)
        {
            DataSet dsPedidos = new DataSet();
            string Fecha = DateTime.Now.ToString("yyyy/MM/dd");
            dsPedidos = miServicio.mtdNotificacionPedido(Fecha);
            DataTable tblPedido = dsPedidos.Tables["tblDatos"];
            dgvPedidosHoy.DataSource = tblPedido;
            this.dgvPedidosHoy.Columns["IdPedidos"].Visible = false;
            this.dgvPedidosHoy.Columns["idProducto"].Visible = false;
            this.dgvPedidosHoy.Columns["idCliente"].Visible = false;
        }

        int renglon;
        private void dgvPedidosHoy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPedidosHoy.SelectedCells.Count > 0)
                {
                    renglon = e.RowIndex;
                    string Documento;
                    string Nombre;
                    string Apellido;
                    string Telefono;
                    string Municipio;
                    string Nombre1;
                    string Codigo;
                    string Precio;

                    Documento = dgvPedidosHoy.Rows[renglon].Cells["Documento"].Value.ToString();
                    dgvPedidosHoy.Columns["Documento"].ReadOnly = true;
                    txtDocumentoPH.Text = Documento;

                    Nombre = dgvPedidosHoy.Rows[renglon].Cells["Nombre"].Value.ToString();
                    dgvPedidosHoy.Columns["Nombre"].ReadOnly = true;
                    txtNombrePedHP.Text = Nombre;

                    Apellido = dgvPedidosHoy.Rows[renglon].Cells["Apellido"].Value.ToString();
                    dgvPedidosHoy.Columns["Apellido"].ReadOnly = true;
                    txtApellidoPH.Text = Apellido;

                    Telefono = dgvPedidosHoy.Rows[renglon].Cells["Telefono"].Value.ToString();
                    dgvPedidosHoy.Columns["Telefono"].ReadOnly = true;
                    txtTelefonoPH.Text = Telefono;

                    Municipio = dgvPedidosHoy.Rows[renglon].Cells["Municipio"].Value.ToString();
                    dgvPedidosHoy.Columns["Municipio"].ReadOnly = true;
                    txtMunicipioPH.Text = Municipio;

                    Nombre1 = dgvPedidosHoy.Rows[renglon].Cells["Nombre1"].Value.ToString();
                    dgvPedidosHoy.Columns["Nombre1"].ReadOnly = true;
                    txtNombrePedHP.Text = Nombre1;

                    Codigo = dgvPedidosHoy.Rows[renglon].Cells["Codigo"].Value.ToString();
                    dgvPedidosHoy.Columns["Codigo"].ReadOnly = true;
                    txtCodigoPH.Text = Codigo;

                    Precio = dgvPedidosHoy.Rows[renglon].Cells["Precio"].Value.ToString();
                    dgvPedidosHoy.Columns["Precio"].ReadOnly = true;
                    txtPrecioPH.Text = Precio;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
