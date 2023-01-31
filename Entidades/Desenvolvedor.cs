using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativaBD
{

    [Table("tabeladesenvolvedor")]
    public class Desenvolvedor
    {
        public Int64 Id { get; set; }
        public Char Nivel { get; set; }

        public String NivelDev
        {
            get => Nivel.ToString();
            set => Nivel = value[0];
        }

        [Required]
        [StringLength(45)]
        public String Nome { get; set; }

        public Credencial Credencial { get; set; }

        [Column(TypeName = "date")]
        public DateTime Nascimento { get; set; }
        public List<Alocacao> Alocacoes { get; set; }


        public Desenvolvedor()
        {

        }
        public Desenvolvedor(String nome, DateTime nascimento, Char nivel)
        {
            Nome = nome;
            Nascimento = nascimento;
            Nivel = nivel;
        }
        public override string ToString() => Nome;
    }
}
