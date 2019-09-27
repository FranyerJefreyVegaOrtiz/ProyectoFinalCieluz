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
    public partial class Entregados : Form
    {
        servicioEscritorioCieluz.ServidorProyectoSoapClient miServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();
        public Entregados()
        {
            InitializeComponent();
        }

        private void Entregados_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }
        public void mtdCargarDatos()
        {
            DataSet dsPedidos = new DataSet();
            dsPedidos = miServicio.mtdEntregadosEscritorio();
            DataTable tblPedido = dsPedidos.Tables["tblDatos"];
            dgvEntregados.DataSource = tblPedido;
        }
    }
}
