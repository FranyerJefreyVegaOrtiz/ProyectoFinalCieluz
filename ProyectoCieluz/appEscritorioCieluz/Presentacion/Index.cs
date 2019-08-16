using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using appEscritorioCieluz.Presentacion;

namespace appEscritorioCieluz
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSlide_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 220)
            {
                MenuVertical.Width = 55;
            }
            else
                MenuVertical.Width = 220;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Cliente());
        }

        private void btnPedidosHoy_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new PedidosHoy());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Pedidos());
        }

        private void btnDespachados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Despachados());
        }

        private void btnEntregados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Entregados());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            objLogin.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Productos());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
