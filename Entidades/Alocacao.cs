using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtividadeAvaliativaBD
{
    [Table("tabelaalocacao")]
    public class Alocacao
    {
        public Int64 Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public Byte HorasAtuacaoSemanal { get; set; }
        public Decimal Remuneracao { get; set; }
        public Desenvolvedor Dev { get; set; }
        public Projeto Projeto { get; set; }
        public List<Tarefa> Tarefas { get; set; } = new List<Tarefa>();

        public Alocacao() { }
        public Alocacao(DateTime inicio, DateTime termino, byte horasatuacaosemanal, decimal remuneracao, Desenvolvedor dev, Projeto projeto)
        {
            Inicio = inicio;
            Termino = termino;
            HorasAtuacaoSemanal = horasatuacaosemanal;
            Remuneracao = remuneracao;
            Dev = dev;
            Projeto = projeto;
        }

        public override string ToString() => $"Dev: {Dev.Nome} | Projeto: {Projeto.Nome}";
    }
}
