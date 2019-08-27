using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServidorProyecto;


namespace appEscritorioCieluz.Presentacion
{
    public partial class NuevoProducto : Form
    {

        servicioEscritorioCieluz.ServidorProyectoSoapClient MiServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();
        
        public NuevoProducto()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            servicioEscritorioCieluz.clProducto objProducto = new servicioEscritorioCieluz.clProducto();

            objProducto.Nombre = txtNombrePro.Text;
            objProducto.Codigo = txtCodigoPro.Text;
            objProducto.Foto = txtResultado.Text;
            objProducto.Color = txtColorPro.Text;
            objProducto.Diseño = txtDiseñoPro.Text;
            objProducto.Precio = txtPrecioPro.Text;
            objProducto.idAdministrador = int.Parse(cmbAdministrador.SelectedValue.ToString());
            objProducto.Descripcion = txtDescripcionPro.Text;

            int resultado = MiServicio.mtdRegistrarProducto(objProducto);
            if(resultado > 0)
            {
                MessageBox.Show("Creado");
            }
            else
            {
                MessageBox.Show("No Creado");
            }
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            DataSet dsAdmin = new DataSet();
            servicioEscritorioCieluz.clAdministrador objAdmin = new servicioEscritorioCieluz.clAdministrador();
            dsAdmin = MiServicio.mtdListarAdmin(objAdmin);
            DataTable tblAdmin = dsAdmin.Tables["tblDatos"];
            cmbAdministrador.DataSource = tblAdmin;
            cmbAdministrador.DisplayMember = "Nombre";
            cmbAdministrador.ValueMember = "IdAdministrador";
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            servicioEscritorioCieluz.clProducto objProducto = new servicioEscritorioCieluz.clProducto();

            objProducto.Nombre = txtNombrePro.Text;
            objProducto.Codigo = txtCodigoPro.Text;
            objProducto.Foto = txtFotoPro.Text;
            objProducto.Color = txtColorPro.Text;
            objProducto.Diseño = txtDiseñoPro.Text;
            objProducto.Precio = txtPrecioPro.Text;
            objProducto.idAdministrador = int.Parse(cmbAdministrador.SelectedValue.ToString());
            objProducto.Descripcion = txtDescripcionPro.Text;
            
            int resultado = MiServicio.mtdEditarProducto(objProducto);

            if (resultado > 0)
            {
                MessageBox.Show("Editado");
            }
            else
            {
                MessageBox.Show("No Creado");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            servicioEscritorioCieluz.clProducto objProducto = new servicioEscritorioCieluz.clProducto();

            objProducto.Nombre = txtNombrePro.Text;
            objProducto.Codigo = txtCodigoPro.Text;
            objProducto.Foto = txtFotoPro.Text;
            objProducto.Color = txtColorPro.Text;
            objProducto.Diseño = txtDiseñoPro.Text;
            objProducto.Precio = txtPrecioPro.Text;
            objProducto.idAdministrador = int.Parse(cmbAdministrador.SelectedValue.ToString());
            objProducto.Descripcion = txtDescripcionPro.Text;

            int resultado = MiServicio.mtdEliminarProducto(objProducto);

            if (resultado > 0)
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("No Creado");
            }
        }

        

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog.FileName;
                imgFoto.Image = Image.FromFile(imagen);

                txtFotoPro.Text = openFileDialog.FileName;
            }
        }

        private void btnArchivobytes_Click(object sender, EventArgs e)
        {
            string ruta = txtFotoPro.Text;

            byte[] archivoBytes = File.ReadAllBytes(ruta);

            string archivoBase64 = Convert.ToBase64String(archivoBytes);

            txtResultado.Text = archivoBase64;
        }

        private void btnBytesarchivo_Click(object sender, EventArgs e)
        {
            string archivoBase64 = txtResultado.Text;
            byte[] archivoByte = Convert.FromBase64String(archivoBase64);
            File.WriteAllBytes(txtFotoPro.Text, archivoByte);
            MessageBox.Show("Archivo creado correctamente");
        }
    }
}
