using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entity;
using BLL;
using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace saborColombiano
{
    public partial class Registro : Form
    {
        FacturaService facturaService = new FacturaService();
        DetalleService detalleService = new DetalleService();
        List<Factura> facturas;
        public Registro(List<Factura> facturas)
        {
            
            this.facturas = facturas;
            InitializeComponent();
            
            this.btnNuevaFactura.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNuevaFactura.Width, btnNuevaFactura.Height, 15, 15));
            this.btnLiquidar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLiquidar.Width, btnLiquidar.Height, 15, 15));
            this.btnPdf.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPdf.Width, btnPdf.Height, 15, 15));
            this.btnVistaDetallada.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVistaDetallada.Width, btnVistaDetallada.Height, 15, 15));
            this.btnFiltrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFiltrar.Width, btnFiltrar.Height, 15, 15));
            this.tbxBarrabusqueda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxBarrabusqueda.Width, tbxBarrabusqueda.Height, 15, 15));
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            if (facturas==null)
            {
                facturas = facturaService.ConsultarFacturas().Facturas;
            }
            Rellenar();
            
        }

        private void llenarFiltro()
        {
            List<string> estados = new List<string>();
            List<string> conceptos = new List<string>();
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("Todos");
            foreach (Factura factura in facturas)
            {
                bool existencia = false;
                foreach (string concepto in conceptos)
                {
                    if (concepto.Equals(factura.Concepto))
                    {
                        existencia = true;
                    }
                }

                if (!existencia)
                {
                    conceptos.Add(factura.Concepto);
                    cmbFiltro.Items.Add(factura.Concepto);
                }

                
                existencia = false;
                foreach (string estado in estados)
                {
                    if (estado.Equals(factura.Estado))
                    {
                        existencia = true;
                    }
                }

                if (!existencia)
                {
                    estados.Add(factura.Estado);
                    cmbFiltro.Items.Add(factura.Estado);
                }

            }
        }

        public void Rellenar()
        {
            if (facturas!=null)
            {
                TablaFacturas.Rows.Clear();
                foreach (Factura factura in facturas)
                {
                    TablaFacturas.Rows.Add(factura.NumeroFactura, factura.Total, factura.FechaFacturacion.ToString(), factura.IDEmpleado, factura.Concepto, factura.Estado);
                }
                llenarFiltro();
            }
        }

        private void tbxBarrabusqueda_TextChanged(object sender, EventArgs e)
        {
            int tamaño = tbxBarrabusqueda.Text.Length;
            if (tamaño > 0 && facturas.Count>0)
            {
                TablaFacturas.Rows.Clear();
                foreach (Factura factura in facturas)
                {
                    string identificacion = factura.IDEmpleado + "??????????";
                    if (tbxBarrabusqueda.Text.ToLower().Equals(identificacion.ToLower().Substring(0, tamaño)))
                    {
                        TablaFacturas.Rows.Add(factura.NumeroFactura, factura.Total, factura.FechaFacturacion.ToString(), factura.IDEmpleado, factura.Concepto, factura.Estado);
                    }
                    else
                    {
                        string numeroFacturacion = factura.NumeroFactura.ToString().ToLower() + "??????????";
                        if (tbxBarrabusqueda.Text.ToLower().Equals(numeroFacturacion.Substring(0, tamaño)))
                        {
                            TablaFacturas.Rows.Add(factura.NumeroFactura, factura.Total, factura.FechaFacturacion.ToString(), factura.IDEmpleado, factura.Concepto, factura.Estado);
                        }
                    }

                }
            }
            else
            {
                Rellenar();
            }
        }

        private void TablaFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaFacturas.CurrentRow.Cells[5].Value.Equals("Pendiente"))
            {
                btnLiquidar.Enabled = true;
            }
            else
            {
                btnLiquidar.Enabled = false;
            }
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            if (facturas.Count>0 && TablaFacturas.CurrentRow!=null)
            {
                if (TablaFacturas.CurrentRow.Cells[5].Value.Equals("Pendiente"))
                {
                    Factura factura = facturaService.ConsultarFactura(Convert.ToInt32(TablaFacturas.CurrentRow.Cells[0].Value)).Factura;
                    factura.Estado = "Liquidado";
                    FacturaResponse facturaResponse= facturaService.ModificarFactura(factura);
                    if (!facturaResponse.Error)
                    {
                        MessageBox.Show("Factura liquidada correctamente.", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Registro_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(facturaResponse.Mensaje, "Error al intentar liquidar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La factura ya se encuentra liquidada.", "Error al intentar liquidar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No hay registros de factura para liquidar", "Error al intentar liquidar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVistaDetallada_Click(object sender, EventArgs e)
        {
            PlatilloService platilloService = new PlatilloService();
            InsumoService insumoService = new InsumoService();

            if (facturas.Count>0 && TablaFacturas.CurrentRow != null)
            {
                List<Detalle> detalles = new List<Detalle>();
                foreach (Detalle detalle in detalleService.ConsultarDetalles().Detalles)
                {
                    if (TablaFacturas.CurrentRow.Cells[0].Value.Equals(detalle.NumeroFacturacion))
                    {
                        if (!detalle.ReferenciaPlatillo.Equals(""))
                        {
                            detalle.Platillo = platilloService.ConsultarPlatillo(detalle.ReferenciaPlatillo).Platillo;
                        }
                        else
                        {
                            if (!detalle.ReferenciaInsumo.Equals(""))
                            {
                                detalle.Insumo = insumoService.ConsultarInsumo(detalle.ReferenciaInsumo).Insumo;
                            }
                        }
                        detalles.Add(detalle);
                    }
                }
                foreach (Factura factura in facturas)
                {
                    if (factura.NumeroFactura.Equals(TablaFacturas.CurrentRow.Cells[0].Value))
                    {
                        factura.Detalles = detalles;
                        DetalleLista detalleLista = new DetalleLista(factura);
                        detalleLista.lblNumeroFactura.Text = factura.NumeroFactura.ToString();
                        detalleLista.lblDate.Text = factura.FechaFacturacion.ToShortDateString();
                        detalleLista.lblPersona.Text = "Empleado";
                        detalleLista.cbxNombre.Text = factura.NombreEmpleado;
                        detalleLista.cbxNombre.Enabled = false;
                        detalleLista.btnFacturar.Visible = false;
                        detalleLista.lblNumeroID.Text = factura.IDEmpleado;
                        detalleLista.lblSaborColombiano.Text = $"Factura de {TablaFacturas.CurrentRow.Cells[4].Value}";
                        detalleLista.Total.Text = factura.Total.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros de factura para ver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Registro_Load(sender,e);
        }

        private void dateFinal_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla___Registro.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EMPLEADO", "Administracion");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", dateInicio.Value.ToString("dd-MM-yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FACTURA", "Registro");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", dateFinal.Value.ToString("dd-MM-yyyy"));

            string filas = string.Empty;
            double total = 0;
            foreach (DataGridViewRow registro in TablaFacturas.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + registro.Cells["Factura"].Value.ToString() + "</td>";

                filas += "<td>" + registro.Cells["Concepto"].Value.ToString() + "</td>";
                filas += "<td>" + registro.Cells["Fecha"].Value.ToString()  + "</td>";
                filas += "<td>" + registro.Cells["Total"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += Convert.ToDouble(registro.Cells["Total"].Value);
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            bool sinDatos = true;
            TablaFacturas.Rows.Clear();
            foreach (Factura factura in facturas)
            {
                if (factura.FechaFacturacion.Month < dateFinal.Value.Month && factura.FechaFacturacion.Year == dateFinal.Value.Year)
                {
                    if (factura.FechaFacturacion.Month > dateInicio.Value.Month && factura.FechaFacturacion.Year == dateInicio.Value.Year)
                    {
                        sinDatos = false;
                        TablaFacturas.Rows.Add(factura.NumeroFactura, factura.Total, factura.FechaFacturacion.ToString(), factura.IDEmpleado, factura.Concepto, factura.Estado);
                    }
                    if (factura.FechaFacturacion.Month == dateInicio.Value.Month && factura.FechaFacturacion.Day >= dateInicio.Value.Day)
                    {
                        sinDatos = false;
                        TablaFacturas.Rows.Add(factura.NumeroFactura, factura.Total, factura.FechaFacturacion.ToString(), factura.IDEmpleado, factura.Concepto, factura.Estado);
                    }

                }
                if (factura.FechaFacturacion.Month == dateFinal.Value.Month && factura.FechaFacturacion.Day <= dateFinal.Value.Day)
                {
                    sinDatos = false;
                    TablaFacturas.Rows.Add(factura.NumeroFactura, factura.Total, factura.FechaFacturacion.ToString(), factura.IDEmpleado, factura.Concepto, factura.Estado);
                }

            }
            if (sinDatos)
            {
                MessageBox.Show("No hay registro de facturas en las fechas establecidas.", "Error al buscar facturas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            Entity.Factura factura = new Factura();
            factura.Detalles = new List<Detalle>();
            factura.NumeroFactura = facturaService.ConsultarFacturas().Facturas.Count + 1;
            factura.FechaFacturacion = DateTime.Now;
            NuevaFactura nuevaFactura = new NuevaFactura(factura);
            if (!factura.Concepto.Equals("Cancelada") )
            {
                DetalleLista detalleLista = new DetalleLista(factura);
            }
            Registro_Load(sender,e);
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            TablaFacturas.Rows.Clear();
            foreach (Factura factura in facturas)
            {
                if (factura.Concepto.Equals(cmbFiltro.SelectedItem) || factura.Estado.Equals(cmbFiltro.SelectedItem))
                {
                    TablaFacturas.Rows.Add(factura.NumeroFactura, factura.Total, factura.FechaFacturacion.ToString(), factura.IDEmpleado, factura.Concepto, factura.Estado);
                }
            }
            if (cmbFiltro.SelectedIndex==0)
            {
                Registro_Load(sender, e);
            }
        }
    }
}
