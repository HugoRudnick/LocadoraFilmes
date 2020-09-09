using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Locadora.Modelos
{
    public class Generos
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataCriacao { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Ativo { get; set; }
    }
}
