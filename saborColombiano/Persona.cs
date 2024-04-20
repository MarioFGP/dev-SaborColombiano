using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace saborColombiano
{
    public partial class Persona : Form
    {

        PersonaService personaService = new PersonaService();
        public Persona()
        {
            InitializeComponent();
            modificaciones();
        }


        private void modificaciones()
        {
            imgBusqued.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, imgBusqued.Width, imgBusqued.Height, 10, 10));
            this.btnRegistrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegistrar.Width, btnRegistrar.Height, 15, 15));
            this.btnModificar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 15, 15));
            this.btnEliminar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEliminar.Width, btnEliminar.Height, 15, 25));
            this.tbxBarrabusqueda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxBarrabusqueda.Width, tbxBarrabusqueda.Height, 15, 15));
            tbxCorreo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxCorreo.Width, tbxCorreo.Height, 15, 15));
            tbxDescripcion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxDescripcion.Width, tbxDescripcion.Height, 15, 15));
            tbxIdentificacion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxIdentificacion.Width, tbxIdentificacion.Height, 15, 15));
            tbxNombre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxNombre.Width, tbxNombre.Height, 15, 15));
            tbxTelefono.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxTelefono.Width, tbxTelefono.Height, 15, 15));
            tbxSueldo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxSueldo.Width, tbxSueldo.Height, 15, 15));
        }

        public void RellenarCampos(Entity.Persona persona)
        {
            tbxIdentificacion.Text = persona.Identificacion;
            tbxNombre.Text = persona.Nombre;
            tbxCorreo.Text = persona.Correo;
            tbxTelefono.Text = persona.Telefono;
            if (persona.TipoPersona.Equals("Empleado"))
            {
                tbxDescripcion.Enabled = false;
                cmbPersona.SelectedIndex = 0;
            }
            else
            {

                tbxDescripcion.Text = persona.Descripcion;
                cmbPersona.SelectedIndex = 1;
                tbxDescripcion.Enabled = true;
            }
            
        }

        private void cmbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersona.SelectedItem.Equals("Proveedor"))
            {
                tbxDescripcion.Enabled = true;
                tbxSueldo.Enabled = false;
            }
            else
            {
                tbxSueldo.Enabled = true;
                tbxDescripcion.Enabled = false;
            }
        }

       

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposLlenos())
            {
                Entity.Persona persona = new Entity.Persona();
                persona.Identificacion = tbxIdentificacion.Text;
                persona.Nombre = tbxNombre.Text;
                persona.Telefono = tbxTelefono.Text;
                persona.TipoPersona = cmbPersona.SelectedItem.ToString();
                if (tbxDescripcion.Enabled)
                {
                    persona.Descripcion = tbxDescripcion.Text;
                }
                else
                {
                    persona.Descripcion = "";
                }
                
                persona.Correo = tbxCorreo.Text;
                if (tbxSueldo.Enabled)
                {
                    persona.Sueldo = Convert.ToDouble(tbxSueldo.Text);
                }
                else
                {
                    persona.Sueldo=0;
                }
                persona.Estado = "Activo";

                PersonaResponse personaResponse = personaService.GuardarPersona(persona);
                if (!personaResponse.Error)
                {
                    MessageBox.Show("Persona guardada con exito", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(personaResponse.Mensaje, "No se pudo guardar a la persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbxCorreo.Text = "";
            tbxIdentificacion.Text = "";
            tbxNombre.Text = "";
            tbxDescripcion.Enabled = false;
            cmbPersona.Text = "";
            tbxTelefono.Text = "";

        }

        public bool ValidarCamposLlenos()
        {
            bool llenos = true;
            if (tbxCorreo.Text.Length<=0 || tbxTelefono.Text.Length<=0)
            {
                llenos = false;
            }
            if (tbxIdentificacion.Text.Length<=0 || tbxNombre.Text.Length<=0 )
            {
                llenos = false;
            }
            if (cmbPersona.SelectedIndex<0)
            {
                llenos = false;
            }

            return llenos;
        }

        private void imgBusqued_Click_1(object sender, EventArgs e)
        {
            VaciarCampos();
            if (!imgBusqued.Equals(""))
            {

                PersonaResponse  personaResponse = personaService.ConsultarPersona(tbxBarrabusqueda.Text);
                if (!personaResponse.Error)
                {
                    RellenarCampos(personaResponse.Persona);
                }
                else
                {
                    PersonaResponse respuesta = personaService.ConsultarPersonaNombre(tbxBarrabusqueda.Text.ToLower());
                    if (!respuesta.Error)
                    {
                        RellenarCampos(respuesta.Persona);
                        tbxIdentificacion.Enabled = false;
                        DialogResult resultado = MessageBox.Show("La persona ya se encuentra registrada, pero inactiva ¿Desea activarla nuevamente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            personaResponse.Persona.Estado = "Activo";
                            personaService.ModificarJuridica(personaResponse.Persona);
                        }
                        else
                        {
                            if (resultado == DialogResult.No)
                            {
                                VaciarCampos();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Asegurese de que la identificacion o el nombre estén bien escrito", "No se pudo encontrar el insumo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCamposLlenos())
            {
                Entity.Persona persona = new Entity.Persona(tbxIdentificacion.Text,tbxNombre.Text,tbxTelefono.Text, tbxCorreo.Text,cmbPersona.Text,"Activo", tbxDescripcion.Text);
                PersonaResponse personaResponse = personaService.ModificarJuridica(persona);
                if (!personaResponse.Error)
                {
                    MessageBox.Show("Persona modificada con exito", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(personaResponse.Mensaje, "No se pudo modificar a la persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposLlenos())
            {
                Entity.Persona persona = new Entity.Persona(tbxIdentificacion.Text, tbxNombre.Text, tbxTelefono.Text, tbxCorreo.Text, cmbPersona.Text, "Inactivo", tbxDescripcion.Text);
                PersonaResponse personaResponse = personaService.ModificarJuridica(persona);
                if (!personaResponse.Error)
                {
                    MessageBox.Show("Persona eliminada con exito", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show(personaResponse.Mensaje, "No se pudo eliminar a la persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos. Intente usando la barra de busqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void imgBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void tbxSueldo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
