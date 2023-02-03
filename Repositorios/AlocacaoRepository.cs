using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativaBD
{
    internal class AlocacaoRepository
    {
        public static void Salvar(Alocacao alocacao)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(alocacao.Dev).State = EntityState.Unchanged;
                    dbContext.Entry(alocacao.Projeto).State = EntityState.Unchanged;

                    if (alocacao.Id == 0)
                    {
                        dbContext.Alocacoes.Add(alocacao);
                    }
                    else
                    {
                        dbContext.Entry(alocacao).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public static void SalvarTarefa(Alocacao alocacao, Tarefa tarefa)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    Alocacao alocacaoindb = new Alocacao();
                    alocacaoindb = dbContext.Alocacoes.FirstOrDefault(a => a.Id == alocacao.Id);
                    alocacaoindb.Tarefas.Add(tarefa);

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Alocacao> EncontrarDevProjeto(string nome)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Alocacoes
                        .Include("Dev").Include("Projeto")
                        .Where(a => a.Dev.Nome.Contains(nome) ||
                        a.Projeto.Nome.Contains(nome)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
       

        public static List<Tarefa> TarefasDesignadas(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    Alocacao alocacao = dbContext.Alocacoes.Include(a => a.Tarefas).FirstOrDefault(a => a.Id == id);

                    return alocacao.Tarefas.ToList();
                }
            }
            catch (Exception)
            { 
                throw;
            }
        }

    }
}


