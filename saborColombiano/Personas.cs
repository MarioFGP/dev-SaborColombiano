using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using Entity;

namespace saborColombiano
{
    public partial class Personas : Form
    {

        PersonaService personaService = new PersonaService();
        List<Entity.Persona> personas = new List<Entity.Persona>();
        List<Entity.Detalle> detalles = new List<Entity.Detalle>();
        FacturaService facturaService = new FacturaService();
        Factura factura = new Factura();
        public Panel pnlRegistro = new Panel();
        public Form form = new Form();
        public Label titulo = new Label();
        public Panel pnlBorde = new Panel();

        DataGridViewRow Fila = new DataGridViewRow();


        public Personas()
        {
            InitializeComponent();
            personas = personaService.ConsultarPersonas().Personas;
            btnVerFacturas.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVerFacturas.Width, btnVerFacturas.Height, 10, 10));
            this.tbxBarrabusqueda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxBarrabusqueda.Width, tbxBarrabusqueda.Height, 15, 15));
            
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            if (personas.Count>0)
            {
                List<Factura> facturas = new List<Factura>();
                foreach (Factura factura in facturaService.ConsultarFacturas().Facturas)
                {
                    if (factura.IDEmpleado.Equals(TablaPersona.CurrentRow.Cells[0].Value))
                    {
                        facturas.Add(factura);
                    }
                }
                this.pnlRegistro.AutoScroll = true;
                this.pnlRegistro.Width = 890;
                this.form.Width = 1080;
                pnlBorde.Width = 894;
                foreach (Control control in form.Controls)
                {
                    if (control.Name.Equals("btnMinimizar"))
                    {
                        
                        control.Location = new Point(1015, control.Location.Y);
                    }
                    if (control.Name.Equals("Cerrarbtn"))
                    {
                        control.Location = new Point(1048, control.Location.Y);
                    }
                    
                }
                titulo.Text = $"{TablaPersona.CurrentRow.Cells[1].Value}";
                titulo.Location = new Point(titulo.Location.X-50, titulo.Location.Y);
                pnlRegistro.Controls.Clear();
                Registro r = new Registro(facturas)
                {

                    TopLevel = false,
                    Location = new Point(10, 10),
                    Dock = DockStyle.None

                };
                r.tbxBarrabusqueda.Visible = false;
                r.imgBusqueda.Visible = false;
                r.btnLiquidar.Visible = false;
                r.lblInicio.Location = new Point(2,r.lblInicio.Location.Y);
                r.lblFinal.Location = new Point(r.lblFinal.Location.X-438, r.lblFinal.Location.Y);
                r.dateFinal.Location = new Point(r.dateFinal.Location.X-438, r.dateFinal.Location.Y);
                r.dateInicio.Location = new Point(r.dateInicio.Location.X-438, r.dateInicio.Location.Y);
                r.btnFiltrar.Location = new Point(r.dateFinal.Location.X+r.dateFinal.Width+10,r.btnFiltrar.Location.Y);
                pnlRegistro.Controls.Add(r);
                r.Show();
            }
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            personas = personaService.ConsultarPersonas().Personas;
            Rellenar();
        }

        public void Rellenar()
        {
            TablaPersona.Rows.Clear();
            foreach (Entity.Persona persona in personas)
            {
                TablaPersona.Rows.Add(persona.Identificacion, persona.Nombre, persona.Telefono, persona.Correo, persona.TipoPersona, persona.Descripcion, persona.Estado);

            }
        }

        private void tbxBarrabusqueda_TextChanged(object sender, EventArgs e)
        {
            int tamaño = tbxBarrabusqueda.Text.Length;
            if (tamaño >= 0 && personas != null)
            {
                TablaPersona.Rows.Clear();
                foreach (Entity.Persona persona in personas)
                {
                    string identificacion = persona.Identificacion + "??????????";
                    if (tbxBarrabusqueda.Text.ToLower().Equals(identificacion.ToLower().Substring(0, tamaño)))
                    {
                        TablaPersona.Rows.Add(persona.Identificacion, persona.Nombre, persona.Telefono, persona.Correo, persona.TipoPersona, persona.Descripcion, persona.Estado);
                    }
                    else
                    {
                        string nombre = persona.Nombre.ToLower() + "??????????";
                        if (tbxBarrabusqueda.Text.ToLower().Equals(nombre.Substring(0, tamaño)))
                        {
                            TablaPersona.Rows.Add(persona.Identificacion, persona.Nombre, persona.Telefono, persona.Correo, persona.TipoPersona, persona.Descripcion, persona.Estado);

                        }
                    }

                }
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            TablaPersona.Rows.Clear();
           
            foreach (Entity.Persona persona in personas)
            {
                if (persona.TipoPersona.Equals(cmbFiltro.SelectedItem.ToString()))
                {
                    TablaPersona.Rows.Add(persona.Identificacion, persona.Nombre, persona.Telefono, persona.Correo, persona.TipoPersona, persona.Descripcion, persona.Estado);
                }
                        
            }

            if (cmbFiltro.SelectedItem.Equals("Todos"))
            {
                Personas_Load(sender,e);
            }
            
        }

        private void btnDespedir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            
            string id = TablaPersona.CurrentRow.Cells[0].Value.ToString();
            Entity.Persona persona = personaService.ConsultarPersona(id).Persona;
            if (persona!=null)
            {
                factura.Detalles = detalles;
                factura.NumeroFactura = facturaService.ConsultarFacturas().Facturas.Count + 1;
                factura.Concepto = "Pago de nomina";
                factura.Total = persona.Sueldo;
                factura.FechaFacturacion = DateTime.Now;
                DetalleLista detalleLista = new DetalleLista(factura);
                
            }
            else
            {
                MessageBox.Show("Asegurese de haber seleccionado a un empleado", "Error al intentar liquidar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }


    }
}
