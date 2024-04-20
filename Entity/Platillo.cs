using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Platillo
    {
        public Platillo()
        {
        }
        [Key]
        [Column(TypeName = "varchar(15)")]
        public string Referencia { get; set; }
        [Column(TypeName = "Decimal")]
        public double Precio { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Descripcion { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Disponibilidad { get; set; }

        public Platillo(string referencia, double precio, string descripcion)
        {
            Referencia = referencia;
            Precio = precio;
            Descripcion = descripcion;
            Disponibilidad = "Disponible";
        }
    }
}
