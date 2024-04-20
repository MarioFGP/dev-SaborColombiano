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
using System.IO;
using iTextSharp.text;
using iTextSharp.tool.xml;
using iTextSharp.text.pdf;

namespace saborColombiano
{
    public partial class DetalleLista : Form
    {
        FacturaService facturaService = new FacturaService();
        PersonaService personaService = new PersonaService();
        List<Entity.Persona> personas;
        Factura Factura;
        public DetalleLista(Factura factura)
        {
            personas = personaService.ConsultarPersonas().Personas;
            this.Factura = factura;
            InitializeComponent();
            if (!lblNumeroID.Text.Equals("##########"))
            {
                btnPDF.Enabled = true;
            }
            llenarCbxNombre();
            this.ShowDialog();
        }

        public void DetalleLista_Load(object sender, EventArgs e)
        {
            LlenarCampos();
            enlistar();
        }

        public void LlenarCampos()
        {
            lblNumeroFactura.Text = Factura.NumeroFactura.ToString();
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            
            if (Factura.IDEmpleado!=null)
            {
                lblNumeroID.Text = Factura.IDEmpleado;
                btnFacturar.Enabled = false;
            }
            if (Factura.Estado!=null)
            {
                cbxNombre.Text = Factura.NombreEmpleado;
                cbxNombre.Enabled = false;
                
            }
            else
            {
                cbxNombre.Enabled = true;
            }
            lblPersona.Text = "Empleado";
            if (Factura.Concepto.Equals("Venta"))
            {
                lblSaborColombiano.Text = "Factura de venta";
            }
            if (Factura.Concepto.Equals("Compra"))
            {

                lblSaborColombiano.Text = "Factura de compra";
            }
            if (!Factura.Concepto.Equals("Compra") && !Factura.Concepto.Equals("Venta"))
            {
                lblNomina.Text = Factura.Total.ToString();
                lblPagoNomina.Visible = true;
                lblPagoNomina.Text = Factura.Concepto;
                lblNomina.Visible = true;
                lblSaborColombiano.Text = $"Factura de {Factura.Concepto}";
            }
            Total.Text = Factura.Total.ToString();
        }

        public void enlistar()
        {
            foreach (Detalle detalle in Factura.Detalles)
            {
                DetallePlatillo detallePlatillo = new DetallePlatillo();
                if (detalle.Platillo!=null)
                {
                    detallePlatillo.tbxDescripcion.Text = " " + detalle.Platillo.Descripcion;
                    detallePlatillo.tbxPrecio.Text = " " + detalle.PrecioUnidad.ToString();
                    detallePlatillo.tbxReferencia.Text = " " + detalle.Platillo.Referencia;
                    detallePlatillo.tbxCantidad.Text = " " + detalle.Cantidad.ToString();
                }
                else
                {
                    if (detalle.Insumo!=null)
                    {
                        detallePlatillo.tbxDescripcion.Text = " " + detalle.Insumo.Nombre;
                        detallePlatillo.tbxPrecio.Text = " " + detalle.PrecioUnidad;
                        detallePlatillo.tbxReferencia.Text = " " + detalle.Insumo.Referencia;
                        detallePlatillo.tbxCantidad.Text = " " + detalle.Cantidad.ToString();
                    }
                    else
                    {
                        return;
                    }
                }
                pnlPrincipal.Controls.Add(detallePlatillo);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (cbxNombre.SelectedIndex>=0)
            {
                if (Factura!=null)
                {
                    string mensaje = "Factura registrada con exito";
                    Factura.Estado = "Liquidado";
                    if (Factura.Concepto.Equals("Venta"))
                    {
                        mensaje = "Factura registrada con exito. \nIngrese a registro para liquidar la factura";
                        Factura.Estado = "Pendiente";
                    }
                    Factura.Empleado = personaService.ConsultarPersona(lblNumeroID.Text).Persona;
                    Factura.IDEmpleado = Factura.Empleado.Identificacion;
                    Factura.NombreEmpleado = Factura.Empleado.Nombre;
                    FacturaResponse facturaResponse =  facturaService.GuardarFactura(Factura);
                    if (!facturaResponse.Error)
                    {
                        MessageBox.Show(mensaje, "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
                        if (Factura.Concepto.Equals("Compra"))
                        {
                            InsumoService insumoService = new InsumoService();
                            foreach (Entity.Detalle detalle in Factura.Detalles)
                            {
                                Entity.Insumo insumo = insumoService.ConsultarInsumo(detalle.ReferenciaInsumo).Insumo;
                                insumo.Cantidad += detalle.Cantidad;
                                if(insumoService.ModificarInsumo(insumo).Error)
                                {
                                    MessageBox.Show(mensaje, "Error al intentar comprar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        Factura.Detalles.Clear();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(facturaResponse.Mensaje, "Error al intentar facturar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxNombre_TextUpdate(object sender, EventArgs e)
        {
            int tamaño = cbxNombre.Text.Length;
            if (personas!=null && tamaño>0)
            {
                cbxNombre.Items.Clear();
                foreach (Entity.Persona persona in personas)
                {
                    string nombre = persona.Nombre + "??????????";
                    if (persona.TipoPersona.Equals("Empleado"))
                    {
                        if (cbxNombre.Text.ToLower().Equals(nombre.ToLower().Substring(0,tamaño)))
                        {
                            cbxNombre.Items.Add(persona.Nombre);
                        }
                    }
                }

            }

        }

        private void cbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Entity.Persona persona in personas)
            {
                if (persona.Nombre.ToLower().Equals(cbxNombre.SelectedItem.ToString().ToLower()))
                {
                    lblNumeroID.Text = persona.Identificacion;
                }
            }
        }

        private void llenarCbxNombre()
        {
            List<string> nombres = new List<string>();
            foreach (Entity.Persona persona in personas)
            {
                bool existencia = false;
                foreach (string nombre in nombres)
                {
                    if (persona.Nombre.Equals(nombre))
                    {
                        existencia = true;
                    }
                }
                if (!existencia)
                {
                    if (persona.TipoPersona.Equals("Empleado"))
                    {
                        nombres.Add(persona.Nombre);
                        cbxNombre.Items.Add(persona.Nombre);
                    }
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EMPLEADO", cbxNombre.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", lblNumeroID.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FACTURA", lblNumeroFactura.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", Factura.FechaFacturacion.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            if (Factura.Detalles!=null)
            {
                foreach (Detalle detalle in Factura.Detalles)
                {
                    filas += "<tr>";
                    filas += "<td>" + detalle.Cantidad.ToString() + "</td>";
                    if (detalle.Insumo == null)
                    {
                        filas += "<td>" + detalle.Platillo.Descripcion.ToString() + "</td>";
                    }
                    else
                    {
                        if (detalle.Platillo == null)
                        {
                            filas += "<td>" + detalle.Insumo.Nombre.ToString() + "</td>";
                        }
                    }

                    filas += "<td>" + detalle.PrecioUnidad.ToString() + "</td>";
                    filas += "<td>" + detalle.Total.ToString() + "</td>";
                    filas += "</tr>";
                }
            }
            else
            {
                filas += "<tr>";
                filas += "<td>" + 1 + "</td>";
                filas += "<td>" + Factura.Concepto.ToString() + "</td>";
                filas += "<td>" + Factura.Total.ToString() + "</td>";
                filas += "<td>" + Factura.Total.ToString() + "</td>";
                filas += "</tr>";
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", Factura.Total.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.saborColombiano, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(120, 120);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }

        private void lblNumeroID_TextChanged(object sender, EventArgs e)
        {
            btnPDF.Enabled = true;
        }
    }
}
