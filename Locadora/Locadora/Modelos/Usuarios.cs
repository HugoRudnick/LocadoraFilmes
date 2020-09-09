using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Modelos
{
    public class Usuarios
    {

        [Key]
        public int IdUsuario { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Usuario { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Senha { get; set; }

    }
}
