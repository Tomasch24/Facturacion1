using System;
using Capa_negocios;
using System.Runtime.InteropServices;
using capa_presentacion;

namespace Capa_Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (pnMenuV.Width == 350)
            {
                pnMenuV.Width = 86;
            }
            else
            {
                pnMenuV.Width = 350;
            }
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Facturacion Fac = new Facturacion();
            Fac.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes Clients = new Clientes();
            Clients.Show();
        }
    }
}
