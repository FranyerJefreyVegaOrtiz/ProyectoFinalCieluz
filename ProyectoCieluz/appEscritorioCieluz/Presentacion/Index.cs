using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using appEscritorioCieluz.Presentacion;
using System.Drawing;
using System.Data;

namespace appEscritorioCieluz
{
    public partial class Index : Form
    {
        servicioEscritorioCieluz.ServidorProyectoSoapClient MiServicio = new servicioEscritorioCieluz.ServidorProyectoSoapClient();
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
            //----Con efecto
            /*if (MenuVertical.Width == 220)
            {
                this.tmContraerMenu.Start();
            }
            else if (MenuVertical.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }*/

            //----Sin efecto
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

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Produccion());
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
            if (MessageBox.Show("¿Esta seguro de cerrar?", "Alerta!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
	        {

            }
        }

        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1300, 650);
            this.Location = new Point(LX,LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (MenuVertical.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                MenuVertical.Width = MenuVertical.Width - 5;
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (MenuVertical.Width >= 220)
                this.tmExpandirMenu.Stop();
            else
                MenuVertical.Width = MenuVertical.Width + 5;
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblHora_TextChanged(object sender, EventArgs e)
        {
            mtdNotificacion();
        }

        public void mtdNotificacion()
        {

            DataSet dsPedidos = new DataSet();
            string Fecha = DateTime.Now.ToString("yyyy/MM/dd");
            dsPedidos = MiServicio.mtdNotificacionPedido(Fecha);
            DataTable tblNoti = dsPedidos.Tables["tblDatos"];
            if (tblNoti.Rows.Count != 0)
            {
                btnPedidosHoy.BackColor = Color.Red;
            }
            else
            {
                btnPedidosHoy.BackColor = Color.Gray;
            }
        }
    }
}
