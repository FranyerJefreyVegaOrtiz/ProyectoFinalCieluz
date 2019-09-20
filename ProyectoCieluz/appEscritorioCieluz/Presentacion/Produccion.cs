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
    }
}
