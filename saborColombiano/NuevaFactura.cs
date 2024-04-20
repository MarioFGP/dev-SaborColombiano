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

namespace saborColombiano
{
    public partial class NuevaFactura : Form
    {
        private Factura Factura;
        public NuevaFactura(Factura factura)
        {
            Factura = factura;
            InitializeComponent();
            this.ShowDialog();
        }

        private void tbxTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Factura.Concepto = "Cancelada";
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!tbxTotal.Text.Equals("") && !tbxConcepto.Text.Equals(""))
            {
                Factura.Concepto = tbxConcepto.Text;
                Factura.Total = Convert.ToDouble(tbxTotal.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacíos.", "Error al buscar crear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
