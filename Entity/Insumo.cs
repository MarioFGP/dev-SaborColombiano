using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Insumo
    {
        public Insumo()
        {
        }
        
        [Key]
        [Column(TypeName = "varchar(15)")]
        public string Referencia { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Nombre { get; set; }
        [Column(TypeName = "int")]
        public int Cantidad { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Descripcion { get; set; }
        [Column(TypeName = "Decimal")]
        public double PrecioUnidad { get; set; }

        public Insumo(string referencia, string nombre, int cantidad, double PrecioUnidad, string descripcion)
        {
            Referencia = referencia;
            Nombre = nombre;
            Cantidad = cantidad;
            this.PrecioUnidad = PrecioUnidad;
            Descripcion = descripcion;
        }

        public Insumo(string referencia, string nombre, double PrecioUnidad, string descripcion)
        {
            Referencia = referencia;
            Nombre = nombre;
            Cantidad = 0;
            this.PrecioUnidad = PrecioUnidad;
            Descripcion = descripcion;
        }
    }
}
