using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtividadeAvaliativaBD
{
    [Table("tabelatarefas")]
    public class Tarefa
    {
        public Int64 Id { get; set; }

        [StringLength(200)]
        public String Descricao { get; set; }

        public Alocacao Alocacao { get; set; }
        public Tarefa()
        {

        }

        public Tarefa(String desc)
        {
            Descricao = desc;
        }

        public override string ToString()
        {
            return $"{Descricao}";
        }
    }
}

