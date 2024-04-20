using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public int NumeroFactura { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string IDEmpleado { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string NombreEmpleado { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Estado { get; set; }
        [NotMapped]
        public Persona Empleado { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime FechaFacturacion { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Concepto {get; set;}
        [Column(TypeName = "Decimal")]
        public double Total { get; set; }
        [JsonIgnore]
        public List<Detalle> Detalles { get; set; }

        public Factura(int numeroFactura, List<Detalle> detalles, DateTime fechaFacturacion, double total)
        {
            NumeroFactura = numeroFactura;
            Detalles = detalles;
            FechaFacturacion = fechaFacturacion;
            Total = total;
        }

        public Factura()
        {
            Detalles = new List<Detalle>();
        }

        public Factura(int numeroFactura, List<Detalle> detalles, DateTime fechaFacturacion)
        {
            NumeroFactura = numeroFactura;
            Detalles = detalles;
            FechaFacturacion = fechaFacturacion;
            Total = CalcularTotal();
        }


        public double CalcularTotal()
        {
            double total = 0;
            foreach (Detalle detalle in Detalles)
            {
                total += detalle.Total;
            }
            this.Total = total;

            return total;
        }
    }
}
