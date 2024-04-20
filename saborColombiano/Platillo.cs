using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
using System.Windows.Forms;

namespace saborColombiano
{
    public partial class Platillo : Form
    {
        PlatilloService platilloService;
        public Platillo()
        {
            InitializeComponent();
        }

        private void Platillo_Load(object sender, EventArgs e)
        {
            tbxReferencia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxReferencia.Width, tbxReferencia.Height, 20, 20));
            tbxPrecio.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxPrecio.Width, tbxPrecio.Height, 20, 20));
            tbxDescripcion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxDescripcion.Width, tbxDescripcion.Height, 20, 20));
            btnRegistrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegistrar.Width, btnRegistrar.Height, 20, 20));
            btnEliminar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEliminar.Width, btnEliminar.Height, 20, 20));
            btnModificar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 20, 20));
            imgBusqueda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, imgBusqueda.Width, imgBusqueda.Height, 10, 10));
            tbxBarrabusqueda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxBarrabusqueda.Width, tbxBarrabusqueda.Height, 10, 10));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbxDescripcion.Text.Length > 5 && tbxPrecio.Text.Length >2 && tbxReferencia.Text.Length > 0)
            {
                Entity.Platillo platillo = new Entity.Platillo(tbxReferencia.Text, Convert.ToDouble(tbxPrecio.Text), tbxDescripcion.Text);
                platilloService = new PlatilloService();
                PlatilloResponse objectResponse = platilloService.GuardarPlatillo(platillo);
                if (!objectResponse.Error)
                {
                    MessageBox.Show("Producto guardado con exito", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(objectResponse.Mensaje, "No se pudo guardar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void imgBusqueda_Click(object sender, EventArgs e)
        {
            
            if (tbxBarrabusqueda.Text.Length>0)
            {
                platilloService = new PlatilloService();
                PlatilloResponse objectResponse = platilloService.ConsultarPlatillo(tbxBarrabusqueda.Text);
                if (!objectResponse.Error)
                {
                    Entity.Platillo platillo = (Entity.Platillo)objectResponse.Platillo;
                    RellenarCampos(platillo);
                    if (platillo.Disponibilidad.Equals("Obsoleto"))
                    {
                        DialogResult resultado = MessageBox.Show("El producto se encuentra en desuso ¿Quiere volver a implementarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            platillo.Disponibilidad = "Disponible";
                            platilloService.ModificarPlatillo(platillo);
                        }
                        else
                        {
                            if (resultado==DialogResult.No)
                            {
                                VaciarCampos();
                            }
                        }
                    }
                    tbxReferencia.Enabled = false;
                }
                else
                {
                    PlatilloResponse respuesta = platilloService.ConsultarPlatilloNombre(tbxBarrabusqueda.Text);
                    if (!respuesta.Error)
                    {
                        Entity.Platillo platillo = (Entity.Platillo)respuesta.Platillo;
                        RellenarCampos(platillo);
                    }
                    else
                    {
                        MessageBox.Show("Asegurese de que el nombre o la referencia estén bien escritas", "No se pudo encontrar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }


        public void RellenarCampos(Entity.Platillo platillo)
        {
            tbxDescripcion.Text = platillo.Descripcion;
            tbxPrecio.Text = platillo.Precio.ToString();
            tbxReferencia.Text = platillo.Referencia;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbxDescripcion.Text.Length>3 && tbxPrecio.Text.Length>3 && tbxReferencia.Text.Length>0)
            {
                Entity.Platillo platillo = new Entity.Platillo(tbxReferencia.Text, Convert.ToDouble(tbxPrecio.Text), tbxDescripcion.Text);
                platilloService = new PlatilloService();
                PlatilloResponse objectResponse = platilloService.ModificarPlatillo(platillo);
                if (!objectResponse.Error)
                {
                    MessageBox.Show("Producto modificado con éxito", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(objectResponse.Mensaje, "No se pudo modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tbxDescripcion.Text.Length > 3 && tbxPrecio.Text.Length > 3 && tbxReferencia.Text.Length > 0)
            {
                Entity.Platillo platillo = new Entity.Platillo(tbxReferencia.Text, Convert.ToDouble(tbxPrecio.Text), tbxDescripcion.Text);
                platilloService = new PlatilloService();
                platillo.Disponibilidad = "Obsoleto";
                PlatilloResponse objectResponse = platilloService.ModificarPlatillo(platillo);
                if (!objectResponse.Error)
                {
                    MessageBox.Show("Producto eliminado con éxito", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(objectResponse.Mensaje, "No se pudo modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void VaciarCampos()
        {
            tbxBarrabusqueda.Text = "";
            tbxDescripcion.Text = "";
            tbxPrecio.Text = "";
            tbxReferencia.Text = "";
            
        }
    }
}
