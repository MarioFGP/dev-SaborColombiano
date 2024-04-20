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
    public partial class Insumo : Form
    {
        InsumoService insumoService;
        public Insumo()
        {
            InitializeComponent();
            modificaciones();
        }

        private void modificaciones()
        {
            this.btnRegistrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegistrar.Width, btnRegistrar.Height, 15, 15));
            this.btnModificar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 15, 15));
            this.btnEliminar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEliminar.Width, btnEliminar.Height, 15, 15));
            this.tbxNombre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxNombre.Width, tbxNombre.Height, 15, 15));
            this.tbxReferencia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxReferencia.Width, tbxReferencia.Height, 15, 15));
            this.tbxPrecio.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxPrecio.Width, tbxPrecio.Height, 15, 15));
            this.tbxDescripcion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxDescripcion.Width, tbxDescripcion.Height, 15, 15));
            imgBusqued.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, imgBusqued.Width, imgBusqued.Height, 10, 10));
            tbxBarrabusqueda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxBarrabusqueda.Width, tbxBarrabusqueda.Height, 10, 10));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbxDescripcion.Text.Length > 1 && tbxPrecio.Text.Length > 1 && tbxReferencia.Text.Length > 0 && tbxNombre.Text.Length>0)
            {
                Entity.Insumo insumo = new Entity.Insumo(tbxReferencia.Text, tbxNombre.Text, Convert.ToDouble(tbxPrecio.Text), tbxDescripcion.Text);
                insumoService = new InsumoService();
                GuardarInsumoResponse insumoResponse = insumoService.GuardarInsumo(insumo);
                if (!insumoResponse.Error)
                {
                    MessageBox.Show("Insumo guardado con exito", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }
                else{
                    MessageBox.Show(insumoResponse.Mensaje, "No se pudo guardar el insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VaciarCampos()
        {
            tbxBarrabusqueda.Text = "";
            tbxDescripcion.Text = "";
            tbxPrecio.Text = "";
            tbxReferencia.Text = "";
            tbxNombre.Text = "";

        }

        public void RellenarCampos(Entity.Insumo insumo)
        {
            tbxDescripcion.Text = insumo.Descripcion;
            tbxPrecio.Text = insumo.PrecioUnidad.ToString();
            tbxReferencia.Text = insumo.Referencia;
            tbxNombre.Text = insumo.Nombre;
        }

        private void imgBusqued_Click(object sender, EventArgs e)
        {
            if (!imgBusqued.Equals(""))
            {
                insumoService = new InsumoService();
                ConsultarInsumoResponse insumoResponse = insumoService.ConsultarInsumo(tbxBarrabusqueda.Text);
                if (!insumoResponse.Error)
                {
                    RellenarCampos(insumoResponse.Insumo);
                }
                else
                {
                    ConsultarInsumoResponse respuesta = insumoService.ConsultarInsumoNombre(tbxBarrabusqueda.Text);
                    if (!respuesta.Error)
                    {
                        RellenarCampos(insumoResponse.Insumo);
                        tbxReferencia.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Asegurese de que el nombre o la referencia estén bien escritas", "No se pudo encontrar el insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbxDescripcion.Text.Length > 1 && tbxPrecio.Text.Length > 1 && tbxReferencia.Text.Length > 0 && tbxNombre.Text.Length > 0)
            {
                Entity.Insumo insumo = new Entity.Insumo(tbxReferencia.Text,tbxNombre.Text,Convert.ToDouble(tbxPrecio.Text), tbxDescripcion.Text);
                insumoService = new InsumoService();
                GuardarInsumoResponse insumoResponse = insumoService.ModificarInsumo(insumo);
                if (!insumoResponse.Error)
                {
                    MessageBox.Show("Insumo modificado con exito", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(insumoResponse.Mensaje, "No se pudo modificar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tbxDescripcion.Text.Length > 1 && tbxPrecio.Text.Length > 1 && tbxReferencia.Text.Length > 0 && tbxNombre.Text.Length > 0)
            {
                Entity.Insumo insumo = new Entity.Insumo(tbxReferencia.Text, tbxNombre.Text,0, Convert.ToDouble(tbxPrecio.Text), tbxDescripcion.Text);
                insumoService = new InsumoService();
                GuardarInsumoResponse insumoResponse = insumoService.ModificarInsumo(insumo);
                if (!insumoResponse.Error)
                {
                    MessageBox.Show("Se han eliminado las existencias con exito", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(insumoResponse.Mensaje, "No se pudo eliminar el insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
