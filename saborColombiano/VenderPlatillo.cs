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
using Entity;
using BLL;

namespace saborColombiano
{
    public partial class VenderPlatillo : Form
    {
        PlatilloService platilloService = new PlatilloService();
        List<Entity.Platillo> platillos = new List<Entity.Platillo>();
        List<Entity.Detalle> detalles = new List<Entity.Detalle>();
        FacturaService facturaService = new FacturaService();
        Factura factura = new Factura();
        DataGridViewRow Fila = new DataGridViewRow();
        public VenderPlatillo()
        {
            InitializeComponent();
            modificaciones();
        }

        public void Rellenar()
        {
            TablaPlatillo.Rows.Clear();          
            foreach (Entity.Platillo platillo in platillos)
            {
                Fila = new DataGridViewRow();
                Fila.CreateCells(TablaPlatillo);
                Fila.Cells[0].Value = platillo.Referencia;
                Fila.Cells[1].Value = platillo.Descripcion;
                Fila.Cells[2].Value = platillo.Precio;
                Fila.Cells[3].Value = platillo.Disponibilidad;
                TablaPlatillo.Rows.Add(Fila);
            }
            
            
        }

        public void modificaciones()
        {
            this.btnEliminar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEliminar.Width, btnEliminar.Height, 15, 15));
            this.btnAgregar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAgregar.Width, btnAgregar.Height, 15, 15));
            this.btnVerLista.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVerLista.Width, btnVerLista.Height, 15, 15));
            this.tbxBarrabusqueda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxBarrabusqueda.Width, tbxBarrabusqueda.Height, 15, 15));

        }

        private void VenderPlatillo_Load(object sender, EventArgs e)
        {
            platillos = platilloService.ConsultarPlatillos().Platillos;
            Rellenar();
        }

        private void pnlTabla_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            factura = new Factura();
            factura.Detalles = detalles;
            factura.NumeroFactura = facturaService.ConsultarFacturas().Facturas.Count + 1;
            factura.Concepto = "Venta";
            factura.CalcularTotal();
            factura.FechaFacturacion = DateTime.Now;
            DetalleLista detalleLista = new DetalleLista(factura);
            VenderPlatillo_Load(sender,e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existencia = false;
            
            if (numCantidad.Value>0)
            {
                Entity.Platillo platillo = new Entity.Platillo();
                platillo.Referencia = TablaPlatillo.CurrentRow.Cells[0].Value.ToString();
                platillo.Descripcion = TablaPlatillo.CurrentRow.Cells[1].Value.ToString();
                platillo.Precio = (double)TablaPlatillo.CurrentRow.Cells[2].Value;
                platillo.Disponibilidad = TablaPlatillo.CurrentRow.Cells[3].Value.ToString();

                foreach (Detalle detalle in detalles)
                {
                    if (detalle.Platillo.Referencia.Equals(platillo.Referencia))
                    {
                        existencia = true;
                        detalle.Cantidad += (int)numCantidad.Value; 
                        numCantidad.Value = 0;
                        detalle.CalcularTotal();
                    }
                }
                if (!existencia)
                {
                    Detalle detail = new Detalle();
                    detail.Codigo = Convert.ToString(facturaService.ConsultarFacturas().Facturas.Count +1+ "" + (detalles.Count + 1));
                    detail.NumeroFacturacion = facturaService.ConsultarFacturas().Facturas.Count+1;
                    detail.Platillo = platillo;
                    detail.ReferenciaPlatillo = platillo.Referencia;
                    detail.PrecioUnidad = platillo.Precio;
                    detail.ReferenciaInsumo = "";
                    detail.Insumo = null;
                    detail.Cantidad = (int)numCantidad.Value;
                    detail.CalcularTotal();
                    detalles.Add(detail);
                    numCantidad.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool existencia = false;
            foreach (Detalle detalle in detalles.ToList())
            {
                if (TablaPlatillo.CurrentRow.Cells[0].Value.ToString().Equals(detalle.Platillo.Referencia))
                {
                    if (numCantidad.Value<=detalle.Cantidad)
                    {
                        detalle.Cantidad -= (int)numCantidad.Value;
                        
                        if (detalle.Cantidad==0)
                        {
                            detalles.Remove(detalle);
                            numCantidad.Value = 0;
                            detalle.CalcularTotal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cantidad que desea eliminar sobrepasa a la cantidad lista de venta","Error al intentar eliminar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    existencia = true;
                }
            }
            if (!existencia)
            {
                MessageBox.Show("El platillo no existe en la lista de venta.", "Error al intentar eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imgBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void tbxBarrabusqueda_TextChanged(object sender, EventArgs e)
        {
            int tamaño = tbxBarrabusqueda.Text.Length;
            if (tamaño > 0 && platillos != null)
            {
                TablaPlatillo.Rows.Clear();
                foreach (Entity.Platillo platillo in platillos)
                {
                    string referencia = platillo.Referencia + "??????????";
                    if (tbxBarrabusqueda.Text.ToLower().Equals(referencia.ToLower().Substring(0, tamaño)))
                    {
                        TablaPlatillo.Rows.Add(platillo.Referencia, platillo.Descripcion, platillo.Precio,platillo.Disponibilidad);
                    }
                    else
                    {
                        string descipcion = platillo.Descripcion.ToLower() + "??????????";
                        if (tbxBarrabusqueda.Text.ToLower().Equals(descipcion.Substring(0, tamaño)))
                        {
                            TablaPlatillo.Rows.Add(platillo.Referencia, platillo.Descripcion, platillo.Precio, platillo.Disponibilidad);
                        }
                    }

                }
                
            }
            else
            {
                Rellenar();
            }
        }
    }
}
