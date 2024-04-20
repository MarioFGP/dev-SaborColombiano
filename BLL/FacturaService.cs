using Entity;
using DAL;
using System.Linq;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class FacturaService
    {
        
        private readonly DatosContext _context;

        public FacturaService(){
            _context = new DatosContext();
            _context.Database.EnsureCreated();
        }

        public FacturaResponse GuardarFactura(Factura factura){
            try
            {
                var _factura = _context.Facturas.Find(factura.NumeroFactura);
                if(_factura!=null){
                    if (factura.NumeroFactura<=ConsultarFacturas().Facturas.Count)
                    {
                        factura.NumeroFactura = ConsultarFacturas().Facturas.LastOrDefault().NumeroFactura + 1;
                        return GuardarFactura(factura);
                    }
                    return new FacturaResponse("Una factura no se puede registrar 2 veces o más.");
                }else{
                    _context.Facturas.Add(factura);
                    _context.SaveChanges();
                    return new FacturaResponse(factura);
                }
            }
            catch (System.Exception e)
            {
                
                return new FacturaResponse("No se pudo validar la existencia de la factura. "+e.Message);
            }
        }

        public double InversionMensual()
        {
            List<Factura> facturas = ConsultarFacturas().Facturas;
            double inversion=0;
            foreach (Factura factura in facturas)
            {
                if (factura.FechaFacturacion.ToString("MM/yyyy").Equals(DateTime.Now.ToString("MM/yyyy")))
                {
                    if (factura.Concepto.Equals("Compra"))
                    {
                        inversion += factura.Total;
                    }
                    
                }
            }

            return inversion;
        }

        public double GastoMensual()
        {
            List<Factura> facturas = ConsultarFacturas().Facturas;
            double gasto = 0;
            foreach (Factura factura in facturas)
            {
                if (factura.FechaFacturacion.ToString("MM/yyyy").Equals(DateTime.Now.ToString("MM/yyyy")))
                {
                    if ((!factura.Concepto.Equals("Compra") && !factura.Concepto.Equals("Venta")) || factura.Estado.Equals("Pendiente"))
                    {
                        gasto += factura.Total;
                    }

                }
            }

            return gasto;
        }

        public double InversionMensual(string fecha)
        {
            List<Factura> facturas = ConsultarFacturas().Facturas;
            double inversion = 0;
            foreach (Factura factura in facturas)
            {
                if (factura.FechaFacturacion.ToString("MM/yyyy").Equals(fecha))
                {
                    if (factura.Concepto.Equals("Compra") )
                    {
                        inversion += factura.Total;
                    }

                }
            }

            return inversion;
        }

        public double GastoMensual(string fecha)
        {
            List<Factura> facturas = ConsultarFacturas().Facturas;
            double inversion = 0;
            foreach (Factura factura in facturas)
            {
                if (factura.FechaFacturacion.ToString("MM/yyyy").Equals(fecha))
                {
                    if (factura.Concepto.Equals("Pago de nomina") || factura.Estado.Equals("Pendiente"))
                    {
                        inversion += factura.Total;
                    }

                }
            }

            return inversion;
        }

        public double GananciaMensual()
        {
            List<Factura> facturas = ConsultarFacturas().Facturas;
            double ganancia = 0;
            foreach (Factura factura in facturas)
            {
                if (factura.Concepto.Equals("Venta"))

                {
                    if (factura.FechaFacturacion.ToString("MM/yyyy").Equals(DateTime.Now.ToString("MM/yyyy")))
                    {
                        if (!factura.Estado.Equals("Pendiente"))
                        {
                            ganancia += factura.Total;
                        }
                    }
                }
            }

            return ganancia;
        }

        public double GananciaMensual(string fecha)
        {
            List<Factura> facturas = ConsultarFacturas().Facturas;
            double ganancia = 0;
            foreach (Factura factura in facturas)
            {
                if (factura.Concepto.Equals("Venta"))

                {
                    if (factura.FechaFacturacion.ToString("MM/yyyy").Equals(fecha))
                    {
                        if (!factura.Estado.Equals("Pendiente"))
                        {
                            ganancia += factura.Total;
                        }
                    }
                }
            }

            return ganancia;
        }


        public double GananciaNeta()
        {
            return GananciaMensual() - InversionMensual() - GastoMensual();
        }

        public double GananciaNeta(string Fecha)
        {

            return GananciaMensual(Fecha) - InversionMensual(Fecha) - GastoMensual(Fecha);
        }

        public double CrecimientoMensual()
        {
            List<Factura> facturas = ConsultarFacturas().Facturas;
            double crecimiento = 0;
            double inversion=0;
            double ganancia = 0;
            foreach (Factura factura in facturas)
            {
                if (factura.FechaFacturacion.ToString("MM/yyyy").Equals(DateTime.Now.AddMonths(-1).ToString("MM/yyyy")))
                {
                    if (factura.Concepto.Equals("Compra") || factura.Estado.Equals("Pendiente"))
                    {
                        inversion += factura.Total;
                    }
                    else
                    {
                        if (factura.Concepto.Equals("Venta"))
                        {
                            ganancia += factura.Total;
                        }
                    }
                }
            }
            double gananciaNeta = ganancia - inversion;
            if (gananciaNeta==0)
            {
                crecimiento = (GananciaNeta() - gananciaNeta) / 1;
            }
            else
            {
                crecimiento = Math.Round(100 * ((GananciaNeta() - gananciaNeta) / Math.Abs(gananciaNeta)),2);
            }
            return crecimiento;
        }

        public double GananciasEnCorriente()
        {
            double generadoCorriente = 0;
            List<Factura> facturas = ConsultarFacturas().Facturas;
            DetalleService detalleService = new();
            List<Detalle> detalles = detalleService.ConsultarDetalles().Detalles;
            foreach (Factura factura in facturas)
            {
                if (factura.Concepto.Equals("Venta"))

                {
                    if (factura.FechaFacturacion.ToString("MM/yyyy").Equals(DateTime.Now.ToString("MM/yyyy")))
                    {
                        if (!factura.Estado.Equals("Pendiente"))
                        {
                            foreach (Detalle detalle in detalles)
                            {
                                if (detalle.NumeroFacturacion == factura.NumeroFactura)
                                {
                                    char platillodetalle =  detalle.ReferenciaPlatillo.ToLower().FirstOrDefault();
                                    if (platillodetalle.Equals('c'))
                                    {
                                        generadoCorriente += detalle.Total;
                                    }
                                }
                            }
                        }
                    }
                }

            }
            return generadoCorriente;
        }
        public double GananciasEnEspeciales()
        {
            double generadoEspeciales = 0;
            List<Factura> facturas = ConsultarFacturas().Facturas;
            DetalleService detalleService = new();
            List<Detalle> detalles = detalleService.ConsultarDetalles().Detalles;
            foreach (Factura factura in facturas)
            {
                if (factura.Concepto.Equals("Venta"))

                {
                    if (factura.FechaFacturacion.ToString("MM/yyyy").Equals(DateTime.Now.ToString("MM/yyyy")))
                    {
                        if (!factura.Estado.Equals("Pendiente"))
                        {
                            foreach (Detalle detalle in detalles)
                            {
                                if (detalle.NumeroFacturacion == factura.NumeroFactura)
                                {
                                    if (detalle.ReferenciaPlatillo.ToLower().FirstOrDefault().Equals('e'))
                                    {
                                        generadoEspeciales += detalle.Total;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return generadoEspeciales;
            
        }
        public ConsultarFacturasResponse ConsultarFacturas(){
            try
            {
                var facturas = _context.Facturas.ToList();
                if(facturas!=null){
                    return new ConsultarFacturasResponse(facturas);
                }else{
                    return new ConsultarFacturasResponse("No hay registro de facturas.");
                }
            }
            catch (System.Exception e)
            {
                
                return new ConsultarFacturasResponse("No se pudo acceder a la base de datos. "+e.Message);
            }
        }

        public FacturaResponse ConsultarFactura(int numeroFactura)
        {
            try
            {
                var factura = _context.Facturas.Where(f => f.NumeroFactura.Equals(numeroFactura)).FirstOrDefault();
                if (factura != null)
                {
                    return new FacturaResponse(factura);
                }
                else
                {
                    return new FacturaResponse("No hay registro de facturas.");
                }
            }
            catch (System.Exception e)
            {

                return new FacturaResponse("No se pudo acceder a la base de datos. " + e.Message);
            }
        }



        public FacturaResponse ModificarFactura(Factura factura){
            try
            {
                var _factura = _context.Facturas.Find(factura.NumeroFactura);
                if(_factura!=null){
                    _context.Facturas.Update(factura);
                    _context.SaveChanges();
                    return new FacturaResponse(factura);
                }else{
                    return new FacturaResponse("No existe el registro, no se puede modificar.");
                }
            }
            catch (System.Exception e)
            {
                
                return new FacturaResponse("No se pudo validar la existencia de la factura. "+e.Message);
            }
        }
    }


    public class FacturaResponse{
        public bool Error {get; set;}
        public string Mensaje {get; set;}

        public Factura Factura {get; set;}

        public FacturaResponse(Factura factura){
            this.Factura = factura;
            Error = false;
        }

        public FacturaResponse(string Mensaje){
            this.Mensaje = Mensaje;
            this.Error = true;
        }

    }


    public class ConsultarFacturasResponse{
        public bool Error {get; set;}
        public string Mensaje {get; set;}

        public List<Factura> Facturas {get; set;} = new();

        public ConsultarFacturasResponse(List<Factura> facturas){
            this.Facturas = facturas;
            this.Error = false;
        }

        public ConsultarFacturasResponse(string mensaje){
            this.Mensaje = mensaje;
            this.Error = true;
        }

    }
}