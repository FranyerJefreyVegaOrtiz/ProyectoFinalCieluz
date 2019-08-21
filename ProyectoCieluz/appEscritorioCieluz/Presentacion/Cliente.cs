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
            //DataSet dsProducto = new DataSet();
            //dsProducto = miServicio.mtdListarPro();
            //DataTable tblAdmin = dsProducto.Tables["tblDatos"];
            //dgvProductos.DataSource = tblAdmin;
            //this.dgvProductos.Columns["IdProducto"].Visible = false;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
