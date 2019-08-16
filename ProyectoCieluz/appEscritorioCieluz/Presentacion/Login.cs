using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace appEscritorioCieluz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "CORREO")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.LightGray;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text=="")
            {
                txtCorreo.Text = "CORREO";
                txtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = false;
             
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text =="")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            mtdLogin();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtCorreo.Clear();
            txtCorreo.Focus();
        }

        servicioEscritorioCieluz.ServidorProyectoSoapClient MiServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();

        static class Globales
        {
            public static string Correo;
            public static string Clave;
        }

        public void mtdLogin()
        {
            DataSet dsLogin = new DataSet();
            Globales.Correo = txtCorreo.Text;
            Globales.Clave = txtContraseña.Text;
            dsLogin = MiServicio.mtdLoginEscritorio(Globales.Correo, Globales.Clave);
            DataTable TablaLogin = dsLogin.Tables["tblDatos"];

            if (TablaLogin.Rows.Count > 0)
            {
                Index objIndex = new Index();
                objIndex.Show();
                objIndex.FormClosed += Logout;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
