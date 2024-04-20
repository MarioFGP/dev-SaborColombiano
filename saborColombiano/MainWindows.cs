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
using Entity;
using BLL;

namespace saborColombiano
{
    public partial class MainWindows : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        Form formulario = new Form();
        public MainWindows(Form form, string usuario)
        {
            InitializeComponent();
            formulario = form;
            lblNombre.Text = usuario;
            lblNombre.Location = new Point(73 - usuario.Length, 98);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnPlatillos_Click(sender,e);
            resetearBotones();
        }

        

        private void resetearBotones()
        {
            btnPlatillos.Location = new Point(0, 225);
            btnInsumo.Location = new Point(0, 275);
            btnProveedor.Location = new Point(0,325);
            btnRegistros.Location = new Point(0,375);
            btnEstadistica.Location = new Point(0,425);
            btnRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            btnEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            btnPlatillos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            btnInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            btnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            pnlbtnsInsumo.Visible = false;
            pnlBtnsPlatillos.Visible = false;
            pnlBtnsPersona.Visible = false;
            btnPlatillos.Image = null;
            btnInsumo.Image = null;
            btnProveedor.Image = null;
            btnEstadistica.Image = null;
            btnRegistros.Image = null;
            this.Width = 1024;
            this.pnlPrincipal.Width = 838;
            pnlBorde.Width = 838;
            Cerrarbtn.Location = new Point(992, 0);
            btnMinimizar.Location = new Point(959, 0);
        }

        private void resetearSubmenu()
        {
            
            btnGestionar.Image = null;
            btnComprar.Image = null;
            bntGestionarInsumo.Image = null;
            btnVender.Image = null;
            btnVerPersonas.Image = null;
            btnGestionarPersonas.Image = null;
            pnlPrincipal.AutoScroll = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnPlatillos_Click(object sender, EventArgs e)
        {
            resetearBotones();
            btnInsumo.Location = new Point(btnInsumo.Location.X, btnPlatillos.Location.Y + 150);
            btnRegistros.Location = new Point(btnRegistros.Location.X, btnPlatillos.Location.Y + 250);
            btnProveedor.Location = new Point(btnProveedor.Location.X, btnPlatillos.Location.Y + 200);
            btnEstadistica.Location = new Point(btnEstadistica.Location.X, btnPlatillos.Location.Y + 300);
            pnlBtnsPlatillos.Location = new Point(0,275);
            pnlBtnsPlatillos.Visible = true;
            btnPlatillos.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_10;
            btnVender_Click(sender,e);

        }

        private void btnInsumo_Click(object sender, EventArgs e)
        {
            resetearBotones();
            pnlBtnsPlatillos.Visible = false;
            btnInsumo.Location = new Point(0, 275);
            pnlbtnsInsumo.Location = new Point(0,btnInsumo.Location.Y + 50);
            pnlbtnsInsumo.Visible = true;
            btnRegistros.Location = new Point(btnRegistros.Location.X, btnInsumo.Location.Y + 200);
            btnProveedor.Location = new Point(btnProveedor.Location.X, btnInsumo.Location.Y + 150);
            btnEstadistica.Location = new Point(btnEstadistica.Location.X, btnInsumo.Location.Y + 250);
            btnInsumo.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_10;
            bntGestionarInsumo_Click(sender, e);
            
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            resetearBotones();
            pnlBtnsPersona.Location = new Point(0,btnProveedor.Location.Y+50);
            btnRegistros.Location = new Point(btnRegistros.Location.X, btnProveedor.Location.Y+150);
            btnEstadistica.Location = new Point(btnEstadistica.Location.X, btnProveedor.Location.Y +200);
            pnlBtnsPersona.Visible = true;
            btnProveedor.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_10;
            btnGestionarPersonas_Click(sender, e);
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            resetearBotones();
            resetearSubmenu();
            btnRegistros.BackColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(214)))));
            btnRegistros.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_50__1___1_;
            pnlPrincipal.Controls.Clear();
            this.lblTitulo.Text = "Historial de facturas";
            pnlPrincipal.AutoScroll = true;
            this.Width = 1080;
            this.pnlPrincipal.Width = 890;
            pnlBorde.Width = 894;
            Cerrarbtn.Location = new Point(1048, Cerrarbtn.Location.Y);
            btnMinimizar.Location = new Point(1015, btnMinimizar.Location.Y);
            pnlBorde.Width = 823;
            Registro registro = new Registro(null)
            {
                TopLevel = false,
                Location = new Point(10, 10),
                Dock = DockStyle.None

            };
            pnlPrincipal.Controls.Add(registro);
            registro.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            if(formulario!=null){
                formulario.Visible = true;
            }
        }

        private void btnPlatillos_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnInsumo_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnProveedor_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnRegistros_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            resetearBotones();
            resetearSubmenu();
            this.lblTitulo.Text = "Estadisticas";
            btnEstadistica.BackColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(214)))));
            btnEstadistica.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_50__1___1_;
            pnlPrincipal.Controls.Clear();
            Estadisticas estadisticas = new Estadisticas
            {
                TopLevel = false,
                Location = new Point(10, 10),
                Dock = DockStyle.None
            };
            pnlPrincipal.Controls.Add(estadisticas);
            estadisticas.Show();

        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            resetearSubmenu();
            btnGestionar.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_50__1___1_;
            this.lblTitulo.Text = "Gestión productos";
            pnlPrincipal.Controls.Clear();
            Platillo platillo = new Platillo
            {
                TopLevel = false,
                Location = new Point(10, 10),
                Dock = DockStyle.None

            };
            pnlPrincipal.Controls.Add(platillo);
            platillo.Show();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            resetearSubmenu();
            btnVender.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_50__1___1_;
            this.lblTitulo.Text = "Venta de productos";
            pnlPrincipal.Controls.Clear();
            VenderPlatillo venderPlatillo = new VenderPlatillo
            {
                TopLevel = false,
                Location = new Point(10, 10),
                Dock = DockStyle.None

            };
            pnlPrincipal.Controls.Add(venderPlatillo);
            venderPlatillo.Show();
        }

        private void bntGestionarInsumo_Click(object sender, EventArgs e)
        {
            resetearSubmenu();
            this.lblTitulo.Text = "Gestión de insumos";
            bntGestionarInsumo.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_50__1___1_;
            pnlPrincipal.Controls.Clear();
            Insumo insumo = new Insumo
            {
                TopLevel = false,
                Location = new Point(10, 10),
                Dock = DockStyle.None

            };
            pnlPrincipal.Controls.Add(insumo);
            insumo.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            resetearSubmenu();
            this.lblTitulo.Text = "Compra de insumos";
            btnComprar.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_50__1___1_;
            pnlPrincipal.Controls.Clear();
            ComprarInsumo comprarInsumo = new ComprarInsumo
            {
                TopLevel = false,
                Location = new Point(10, 10),
                Dock = DockStyle.None

            };
            pnlPrincipal.Controls.Add(comprarInsumo);
            comprarInsumo.Show();
        }

        private void btnGestionarPersonas_Click(object sender, EventArgs e)
        {
            resetearSubmenu();
            this.lblTitulo.Text = "Gestion de personas";
            btnGestionarPersonas.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_50__1___1_;
            pnlPrincipal.Controls.Clear();
            Persona persona = new Persona
            {
                TopLevel = false,
                Location = new Point(10, 10),
                Dock = DockStyle.None

            };
            pnlPrincipal.Controls.Add(persona);
            persona.Show();
        }

        private void btnVerPersonas_Click(object sender, EventArgs e)
        {
            resetearSubmenu();
            this.lblTitulo.Text = "Registro de personas";
            btnVerPersonas.Image = global::saborColombiano.Properties.Resources.icons8_chebrón_hacia_la_derecha_50__1___1_;
            pnlPrincipal.Controls.Clear();
            Personas personas = new Personas
            {
                TopLevel = false,
                Location = new Point(10, 10),
                Dock = DockStyle.None,
                pnlRegistro = this.pnlPrincipal,
                form = this,
                titulo = lblTitulo,
                pnlBorde = this.pnlBorde

            };
            pnlPrincipal.Controls.Add(personas);
            personas.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBorde_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }

        private void Cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (formulario != null)
            {
                formulario.Visible = true;
            }
        }
    }
}
