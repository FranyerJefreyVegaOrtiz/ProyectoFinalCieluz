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
            dsPedidos = miServicio.mtdListarPed();
            DataTable tblPedido = dsPedidos.Tables["tblDatos"];
            dgvPedidos.DataSource = tblPedido;
            this.dgvPedidos.Columns["IdPedido"].Visible = false;
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }
    }
}
