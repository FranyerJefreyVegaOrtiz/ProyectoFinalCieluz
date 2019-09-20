using appEscritorioCieluz.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                    string Foto;
                    string Cantidad;
                    string Talla;
                    string PrecioTotal;
                    string TipoPago;
                    string IdCliente;
                    string IdProducto;


                    //Foto = dgvPedidos.Rows[renglon].Cells["Foto"].Value.ToString();
                    //dgvPedidos.Columns["Foto"].ReadOnly = true;
                    //string archivoBase64 = "Foto";
                    //byte[] archivoByte = Convert.FromBase64String(archivoBase64);
                    //File.WriteAllBytes(pbxImagen.Image.ToString(), archivoByte);


                    Cantidad = dgvPedidos.Rows[renglon].Cells["Cantidad"].Value.ToString();
                    dgvPedidos.Columns["Cantidad"].ReadOnly = true;
                    txtCantidad.Text = Cantidad;

                    Talla = dgvPedidos.Rows[renglon].Cells["Talla"].Value.ToString();
                    dgvPedidos.Columns["Talla"].ReadOnly = true;
                    txtTalla.Text = Talla;

                    PrecioTotal = dgvPedidos.Rows[renglon].Cells["PrecioTotal"].Value.ToString();
                    dgvPedidos.Columns["PrecioTotal"].ReadOnly = true;
                    txtPrecioTotal.Text = PrecioTotal;

                    TipoPago = dgvPedidos.Rows[renglon].Cells["TipoPago"].Value.ToString();
                    dgvPedidos.Columns["TipoPago"].ReadOnly = true;
                    txtTipoPago.Text = TipoPago;

                    IdCliente = dgvPedidos.Rows[renglon].Cells["IdCliente"].Value.ToString();
                    dgvPedidos.Columns["IdCliente"].ReadOnly = true;
                    txtIdCliente.Text = IdCliente;

                    IdProducto = dgvPedidos.Rows[renglon].Cells["IdProducto"].Value.ToString();
                    dgvPedidos.Columns["IdProducto"].ReadOnly = true;
                    txtIdProducto.Text = IdProducto;
                }
            }
            catch
            {
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            servicioEscritorioCieluz.clPedidos objPedidos = new servicioEscritorioCieluz.clPedidos();

            objPedidos.Nit = txtNit.Text;
            objPedidos.Estado = txtEstado.Text;
            objPedidos.Cantidad = txtCantidad.Text;
            objPedidos.Talla = txtTalla.Text;
            objPedidos.PrecioTotal = txtPrecioTotal.Text;
            objPedidos.TipoPago = txtTipoPago.Text;
            objPedidos.IdCliente = int.Parse(txtIdCliente.Text);
            objPedidos.IdProducto = int.Parse(txtIdProducto.Text);

            int resultado = miServicio.mtdEditarPedido(objPedidos);
            if (resultado > 0)
            {
                MessageBox.Show("Editado");
                string valor = txtNit.Text + 1;
                txtNit.Text = valor;
            }
            else
            {
                MessageBox.Show("No Se Puede Editar");
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPedidos.SelectedCells.Count > 0)
                {
                    renglon = e.RowIndex;
                    string Foto;
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


                    Cantidad = dgvPedidos.Rows[renglon].Cells["Cantidad"].Value.ToString();
                    dgvPedidos.Columns["Cantidad"].ReadOnly = true;
                    txtCantidad.Text = Cantidad;

                    Talla = dgvPedidos.Rows[renglon].Cells["Talla"].Value.ToString();
                    dgvPedidos.Columns["Talla"].ReadOnly = true;
                    txtTalla.Text = Talla;

                    PrecioTotal = dgvPedidos.Rows[renglon].Cells["PrecioTotal"].Value.ToString();
                    dgvPedidos.Columns["PrecioTotal"].ReadOnly = true;
                    txtPrecioTotal.Text = PrecioTotal;

                    TipoPago = dgvPedidos.Rows[renglon].Cells["TipoPago"].Value.ToString();
                    dgvPedidos.Columns["TipoPago"].ReadOnly = true;
                    txtTipoPago.Text = TipoPago;

                    Estado = dgvPedidos.Rows[renglon].Cells["Estado"].Value.ToString();
                    dgvPedidos.Columns["Estado"].ReadOnly = true;
                    txtEstado.Text = Estado;

                    IdCliente = dgvPedidos.Rows[renglon].Cells["IdCliente"].Value.ToString();
                    dgvPedidos.Columns["IdCliente"].ReadOnly = true;
                    lblIdCliente.Text = IdCliente;

                    IdProducto = dgvPedidos.Rows[renglon].Cells["IdProducto"].Value.ToString();
                    dgvPedidos.Columns["IdProducto"].ReadOnly = true;
                    lblIdProducto.Text = IdProducto;
                }
            }
            catch
            {
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
