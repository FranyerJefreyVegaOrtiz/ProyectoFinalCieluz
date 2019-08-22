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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        servicioEscritorioCieluz.ServidorProyectoSoapClient miServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();

        public void mtdCargarDatos()
        {
            DataSet dsCliente = new DataSet();
            dsCliente = miServicio.mtdListarCli();
            DataTable tblCliente = dsCliente.Tables["tblDatos"];
            dgvCliente.DataSource = tblCliente;
            this.dgvCliente.Columns["IdCliente"].Visible = false;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }
    }
}
