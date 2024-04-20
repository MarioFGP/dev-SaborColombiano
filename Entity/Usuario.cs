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
    public class Usuario
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string IdUsuario { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Contraseña { get; set; }
        [Range(typeof(bool), "true", "false")]
        public bool Estado { get; set; }

        public Usuario(string idUsuario, string nombre, string contraseña)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Estado = true;
        }

        public Usuario()
        {
        }
    }
}
