using appEscritorioCieluz.servicioEscritorioCieluz;
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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        servicioEscritorioCieluz.ServidorProyectoSoapClient miServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevoPro = new NuevoProducto();
            nuevoPro.ShowDialog();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            NuevoProducto frmNewPro = new NuevoProducto();
            if (dgvProductos.SelectedRows.Count > 0)
            {
                frmNewPro.txtNombrePro.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                frmNewPro.txtCodigoPro.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                //frmNewPro.txtColorPro.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                //frmNewPro.txtDiseñoPro.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
                frmNewPro.txtPrecioPro.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
                frmNewPro.cmbAdministrador.Text = dgvProductos.CurrentRow.Cells[8].Value.ToString();
                frmNewPro.txtDescripcionPro.Text = dgvProductos.CurrentRow.Cells[7].Value.ToString();
                frmNewPro.txtFotoPro.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                frmNewPro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        public void mtdCargarDatos()
        {
            DataSet dsProducto = new DataSet();
            dsProducto = miServicio.mtdListarProEscritorio();
            DataTable tblProductos = dsProducto.Tables["tblDatos"];
            dgvProductos.DataSource = tblProductos;
            this.dgvProductos.Columns["IdProducto"].Visible = false;
            this.dgvProductos.Columns["Foto"].Visible = false;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }
    }
}
