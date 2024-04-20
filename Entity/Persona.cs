using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Persona
    {
        [Key]
        [Column(TypeName = "varchar(15)")]
        public string Identificacion { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Telefono {get; set;}
        [Column(TypeName = "varchar(30)")]
        public string Correo { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Estado { get; set; }
        [Column(TypeName = "Decimal")]
        public double Sueldo { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Descripcion { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string TipoPersona { get; set; }

        public Persona(string identificacion, string nombre, string telefono, string correo, string tipoPersona, string estado, string descripcion)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            TipoPersona = tipoPersona;
            Estado = estado;
            Descripcion = descripcion;
        }

        public Persona()
        {

        }
    }
}
