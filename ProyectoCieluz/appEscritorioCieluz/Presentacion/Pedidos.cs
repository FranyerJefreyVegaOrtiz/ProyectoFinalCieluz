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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        servicioEscritorioCieluz.ServidorProyectoSoapClient miServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();

        public void mtdCargarDatos()
        {
            DataSet dsPedidos = new DataSet();
            dsPedidos = miServicio.mtdPedidosEscritorio();
            DataTable tblPedido = dsPedidos.Tables["tblDatos"];
            dgvPedidos.DataSource = tblPedido;
            this.dgvPedidos.Columns["IdPedidos"].Visible = false;
            this.dgvPedidos.Columns["IdProducto"].Visible = false;
            this.dgvPedidos.Columns["IdProducto1"].Visible = false;
            this.dgvPedidos.Columns["IdCliente"].Visible = false;
            this.dgvPedidos.Columns["Foto"].Visible = false;
            this.dgvPedidos.Columns["Descripcion"].Visible = false;
            this.dgvPedidos.Columns["idAdministrador"].Visible = false;
            this.dgvPedidos.Columns["IdCliente1"].Visible = false;
            this.dgvPedidos.Columns["Clave"].Visible = false;
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }

        int renglon;
        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPedidos.SelectedCells.Count > 0)
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

                    Documento = dgvPedidos.Rows[renglon].Cells["Documento"].Value.ToString();
                    dgvPedidos.Columns["Documento"].ReadOnly = true;
                    txtDocumento.Text = Documento;

                    Nombre1 = dgvPedidos.Rows[renglon].Cells["Nombre1"].Value.ToString();
                    dgvPedidos.Columns["Nombre1"].ReadOnly = true;
                    txtNombre.Text = Nombre1;

                    Apellido = dgvPedidos.Rows[renglon].Cells["Apellido"].Value.ToString();
                    dgvPedidos.Columns["Apellido"].ReadOnly = true;
                    txtApellido.Text = Apellido;

                    Telefono = dgvPedidos.Rows[renglon].Cells["Telefono"].Value.ToString();
                    dgvPedidos.Columns["Telefono"].ReadOnly = true;
                    txtTelefono.Text = Telefono;

                    Municipio = dgvPedidos.Rows[renglon].Cells["Municipio"].Value.ToString();
                    dgvPedidos.Columns["Municipio"].ReadOnly = true;
                    txtMunicipio.Text = Municipio;

                    Nombre = dgvPedidos.Rows[renglon].Cells["Nombre"].Value.ToString();
                    dgvPedidos.Columns["Nombre"].ReadOnly = true;
                    txtNombrePed.Text = Nombre;

                    Codigo = dgvPedidos.Rows[renglon].Cells["Codigo"].Value.ToString();
                    dgvPedidos.Columns["Codigo"].ReadOnly = true;
                    txtCodigo.Text = Codigo;

                    Precio = dgvPedidos.Rows[renglon].Cells["Precio"].Value.ToString();
                    dgvPedidos.Columns["Precio"].ReadOnly = true;
                    txtPrecio.Text = Precio;
                }
            }
            catch
            {
            }
        }
    }
}
