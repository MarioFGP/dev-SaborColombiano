using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
namespace saborColombiano
{
    public partial class ComprarInsumo : Form
    {
        public InsumoService insumoService = new InsumoService();
        public List<Entity.Insumo> insumos;
        Factura factura = new Factura();
        List<Entity.Detalle> detalles = new List<Entity.Detalle>();
        FacturaService facturaService = new FacturaService();
        DataGridViewRow Fila;
        public ComprarInsumo()
        {
            InitializeComponent();
            Modificaciones();
            
        }

        private void TablaInsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Modificaciones()
        {
            btnAgregar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAgregar.Width, btnAgregar.Height, 15, 15));
            btnEliminar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEliminar.Width, btnEliminar.Height, 15, 15));
            btnVerLista.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVerLista.Width, btnVerLista.Height, 15, 15));
            btnUsar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUsar.Width, btnUsar.Height, 15, 15));
            tbxBarrabusqueda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxBarrabusqueda.Width, tbxBarrabusqueda.Height, 15, 15));
            imgBusqueda.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, imgBusqueda.Width, imgBusqueda.Height, 10, 10));
        }

        private void ComprarInsumo_Load(object sender, EventArgs e)
        {
            insumos = insumoService.ConsultarInsumos().Insumos;
            RellenarTabla(insumos);
        }

        public void RellenarTabla(List<Entity.Insumo> insumos)
        {
            TablaInsumo.Rows.Clear();
            foreach (Entity.Insumo insumo in insumos)
            {
                Fila = new DataGridViewRow();
                Fila.CreateCells(TablaInsumo);
                Fila.Cells[0].Value = insumo.Referencia;
                Fila.Cells[1].Value = insumo.Nombre;
                Fila.Cells[2].Value = insumo.PrecioUnidad;
                Fila.Cells[3].Value = insumo.Cantidad;
                Fila.Cells[4].Value = insumo.Descripcion;
                TablaInsumo.Rows.Add(Fila);
            }
        }

        private void tbxBarrabusqueda_TextChanged(object sender, EventArgs e)
        {
            int tamaño = tbxBarrabusqueda.Text.Length;
            if (tamaño>=0 && insumos!=null)
            {
                TablaInsumo.Rows.Clear();
                foreach (Entity.Insumo insumo in insumos)
                {
                    string referencia = insumo.Referencia + "??????????";
                    if (tbxBarrabusqueda.Text.ToLower().Equals(referencia.ToLower().Substring(0,tamaño)))
                    {
                        TablaInsumo.Rows.Add(insumo.Referencia, insumo.Nombre, insumo.PrecioUnidad, insumo.Cantidad, insumo.Descripcion);
                    }
                    else
                    {
                        string nombre = insumo.Nombre.ToLower()+"??????????";
                        if (tbxBarrabusqueda.Text.ToLower().Equals(nombre.Substring(0, tamaño)))
                        {
                            TablaInsumo.Rows.Add(insumo.Referencia, insumo.Nombre, insumo.PrecioUnidad, insumo.Cantidad, insumo.Descripcion);
                        }
                    }

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existencia = false;
            if (numCantidad.Value>0)
            {
                Entity.Insumo insumo = new Entity.Insumo();
                insumo.Referencia = TablaInsumo.CurrentRow.Cells[0].Value.ToString();
                insumo.Nombre = TablaInsumo.CurrentRow.Cells[1].Value.ToString();
                insumo.PrecioUnidad = (double)TablaInsumo.CurrentRow.Cells[2].Value;
                insumo.Cantidad = (int)numCantidad.Value;
                insumo.Descripcion = TablaInsumo.CurrentRow.Cells[4].Value.ToString();
                foreach (Detalle detalle in detalles)
                {
                    if (detalle.Insumo.Referencia.Equals(insumo.Referencia))
                    {
                        existencia = true;
                        detalle.Cantidad += (int)numCantidad.Value;
                        detalle.Insumo.Cantidad = detalle.Cantidad;
                        numCantidad.Value = 0;
                        detalle.CalcularTotal();
                    }
                }
                if (!existencia)
                {
                    Detalle detail = new Detalle();
                    detail.Codigo = Convert.ToString(facturaService.ConsultarFacturas().Facturas.Count + 1+"" + (detalles.Count + 1));
                    detail.NumeroFacturacion = facturaService.ConsultarFacturas().Facturas.Count+1;
                    detail.Platillo = null;
                    detail.ReferenciaPlatillo = "";
                    detail.ReferenciaInsumo = insumo.Referencia;
                    detail.Insumo = insumo;
                    detail.PrecioUnidad = insumo.PrecioUnidad;
                    detail.Cantidad = (int)numCantidad.Value;
                    detail.Insumo.Cantidad = detail.Cantidad;
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
                if (TablaInsumo.CurrentRow.Cells[0].Value.Equals(detalle.Insumo.Referencia))
                {
                    if (numCantidad.Value<detalle.Cantidad)
                    {
                        existencia = true;
                        detalle.Cantidad -= (int)numCantidad.Value;
                        detalle.Insumo.Cantidad = detalle.Cantidad;
                        if (detalle.Cantidad==0)
                        {
                            detalles.Remove(detalle);
                            
                        }
                        numCantidad.Value = 0;
                        detalle.CalcularTotal();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad que desea eliminar sobrepasa a la cantidad lista de compra", "Error al intentar eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if(!existencia)
            {
                MessageBox.Show("El producto que desea eliminar no se encuentra en la lista de compra", "Error al intentar eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            factura = new Factura();
            factura.Detalles = detalles;
            factura.NumeroFactura = facturaService.ConsultarFacturas().Facturas.Count + 1;
            factura.Concepto = "Compra";
            factura.FechaFacturacion = DateTime.Now;
            factura.CalcularTotal();
            DetalleLista detalleLista = new DetalleLista(factura);
            ComprarInsumo_Load(sender,e);
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            if (numCantidad.Value < Convert.ToInt32(TablaInsumo.CurrentRow.Cells[3].Value))
            {
                Entity.Insumo insumo = insumoService.ConsultarInsumo(TablaInsumo.CurrentRow.Cells[0].Value.ToString()).Insumo;
                insumo.Cantidad -= Convert.ToInt32(numCantidad.Value);
                if (insumoService.ModificarInsumo(insumo).Error)
                {
                    
                    MessageBox.Show("No se pudo usar el insumo", "Error al intentar usar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
                MessageBox.Show("La cantidad que desea usar sobrepasa a la cantidad en stock", "Error al intentar usar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ComprarInsumo_Load(sender,e);
        }
    }
}
