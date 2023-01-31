using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativaBD
{
    [Table("tabelaprojeto")]
    public class Projeto
    {
        [Required]
        [StringLength(35)]
        public String Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime Inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime TerminoPlanejado { get; set; }

        [Column(TypeName = "date")]
        public DateTime Termino { get; set; }

        public Int64 Id { get; set; }

        public Desenvolvedor Dev { get; set; }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }

}
