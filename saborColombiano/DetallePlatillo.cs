using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saborColombiano
{
    public partial class DetallePlatillo : UserControl
    {
        public DetallePlatillo()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.Show();
            
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 2, this.Width, this.Height, 15, 15));
            tbxCantidad.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxCantidad.Width, tbxCantidad.Height, 15, 15));
            tbxDescripcion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxDescripcion.Width, tbxDescripcion.Height, 15, 15));
            tbxPrecio.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxPrecio.Width, tbxPrecio.Height, 15, 15));
            tbxReferencia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxReferencia.Width, tbxReferencia.Height, 15, 15));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void tbxReferencia_TextChanged(object sender, EventArgs e)
        {

        }


        private void pnlPrincipal_Click(object sender, EventArgs e)
        {
           
        }

        public void DetallePlatillo_Leave(object sender, EventArgs e)
        {
            
        }

        private void pnlPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void tbxPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
