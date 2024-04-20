using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entity
{
    public class Detalle
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string Codigo { get; set; }
        [NotMapped]
        public Platillo Platillo { get; set; }
        [NotMapped]
        public Insumo Insumo { get; set; }
        [Column(TypeName = "int")]
        public int Cantidad { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string ReferenciaInsumo { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string ReferenciaPlatillo { get; set; }
        [Column(TypeName = "Decimal")]
        public double PrecioUnidad { get; set; }
        [Column(TypeName = "Decimal")]
        public double Total { get; set; }
        [Column(TypeName = "varchar(20)")]
        public  int NumeroFacturacion { get; set; }


        public Detalle(string codigo, Platillo platillo, Insumo insumo, int cantidad, int numeroFacturacion)
        {
            Codigo = codigo;
            Platillo = platillo;
            Insumo = insumo;
            Cantidad = cantidad;
            NumeroFacturacion = numeroFacturacion;
            Total = CalcularTotal();
        }

        public Detalle()
        {
        }

        public double CalcularTotal()
        {
            if (this.Platillo!=null)
            {
                Total = Platillo.Precio * Cantidad;
            }
            else
            {
                if (this.Insumo!=null)
                {
                    Total = this.Insumo.PrecioUnidad * Cantidad;
                }
                else
                {
                    return -1;
                }
            }
            return Total;
        }

    }

}
