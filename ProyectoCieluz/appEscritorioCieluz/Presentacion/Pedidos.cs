using appEscritorioCieluz.Presentacion;
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

                    Nombre1 = dgvPedidos.Rows[renglon].Cells["Nombre"].Value.ToString();
                    dgvPedidos.Columns["Nombre"].ReadOnly = true;
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

                    Nombre = dgvPedidos.Rows[renglon].Cells["Nombre1"].Value.ToString();
                    dgvPedidos.Columns["Nombre1"].ReadOnly = true;
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPedidos.SelectedRows)
            {
                string Documento;
                string Apellido;

                Documento = this.dgvPedidos.CurrentRow.Cells[5].Value.ToString();
                Apellido = this.dgvPedidos.CurrentRow.Cells[7].Value.ToString();

                Produccion frmpro = new Produccion();

                frmpro.dgvProduccion.Rows.Add(Documento, Apellido);
            }
        }

        //foreach (DataGridViewRow row in dgvPedidos.SelectedRows)
        //    {
        //        string Cantidad;
        //string Talla;
        //string PrecioTotal;
        //string TipoPago;
        //string TipoDocumento;
        //string Documento;
        //string Nombre;
        //string Apellido;
        //string Telefono;
        //string Correo;
        //string Departamento;
        //string Municipio;
        //string Direccion;
        //string Nombre1;
        //string Codigo;
        //string Precio;
        //string Color;
        //string Diseño;

        //Cantidad = this.dgvPedidos.CurrentRow.Cells[0].Value.ToString();
        //        Talla = this.dgvPedidos.CurrentRow.Cells[1].Value.ToString();
        //        PrecioTotal = this.dgvPedidos.CurrentRow.Cells[2].Value.ToString();
        //        TipoPago = this.dgvPedidos.CurrentRow.Cells[3].Value.ToString();
        //        TipoDocumento = this.dgvPedidos.CurrentRow.Cells[4].Value.ToString();
        //        Documento = this.dgvPedidos.CurrentRow.Cells[5].Value.ToString();
        //        Nombre = this.dgvPedidos.CurrentRow.Cells[6].Value.ToString();
        //        Apellido = this.dgvPedidos.CurrentRow.Cells[7].Value.ToString();
        //        Telefono = this.dgvPedidos.CurrentRow.Cells[8].Value.ToString();
        //        Correo = this.dgvPedidos.CurrentRow.Cells[9].Value.ToString();
        //        Departamento = this.dgvPedidos.CurrentRow.Cells[10].Value.ToString();
        //        Municipio = this.dgvPedidos.CurrentRow.Cells[11].Value.ToString();
        //        Direccion = this.dgvPedidos.CurrentRow.Cells[12].Value.ToString();
        //        Nombre1 = this.dgvPedidos.CurrentRow.Cells[13].Value.ToString();
        //        Codigo = this.dgvPedidos.CurrentRow.Cells[14].Value.ToString();
        //        Precio = this.dgvPedidos.CurrentRow.Cells[15].Value.ToString();
        //        Color = this.dgvPedidos.CurrentRow.Cells[16].Value.ToString();
        //        Diseño = this.dgvPedidos.CurrentRow.Cells[17].Value.ToString();

        //        Produccion frmpro = new Produccion();

        //frmpro.dgvProduccion.Rows.Add(Cantidad, Talla, PrecioTotal, TipoPago, TipoDocumento, Documento, Nombre, Apellido, Telefono, Correo, Departamento, Municipio, Direccion, Nombre1, Codigo, Precio, Color, Diseño);
        //    }
}
}
