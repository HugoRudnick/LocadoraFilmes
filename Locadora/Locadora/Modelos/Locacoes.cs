using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Locadora.Modelos
{
    public class Locacoes
    {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        public int IdFilme { get; set; }

        [Column(TypeName = "int")]
        public int Cpf { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataLocacao { get; set; }

    }
}
