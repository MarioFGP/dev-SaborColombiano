using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace saborColombiano
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            btnEntrar.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEntrar.Width, btnEntrar.Height, 6, 6));
            tbxUsario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxUsario.Width, tbxUsario.Height, 15, 15));
            tbxContasena.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxContasena.Width, tbxContasena.Height, 15, 15));
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioService userService = new UsuarioService();

            if (!userService.ConsultarUsuario(tbxUsario.Text).Error)
            {
                Usuario user = userService.ConsultarUsuario(tbxUsario.Text).Usuario;
                if (user.Contraseña.Equals(tbxContasena.Text))
                {
                    if (user.Estado)
                    {
                        this.Visible = false;
                        MainWindows main = new MainWindows(this, tbxUsario.Text);
                        main.Show();
                        tbxContasena.Text = "";
                        tbxUsario.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El usuario no tiene permisos para acceder", "Error al intentar entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña invalida","Error al intentar entrar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(userService.ConsultarUsuario(tbxUsario.Text).Mensaje, "Error al intentar entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
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
            this.Dispose();
        }

        private void pnlBorde_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tbxContasena_Enter(object sender, EventArgs e)
        {
            btnEntrar_Click(sender, e);
        }

        private void tbxContasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnEntrar_Click(sender,e);
            }
        }
    }
}
