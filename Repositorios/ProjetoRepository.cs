using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AtividadeAvaliativaBD
{
    public class ProjetoRepository
    {
        public static void Salvar(Projeto projeto)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (projeto.Id == 0)
                    {
                        dbContext.Projetos.Add(projeto);
                    }
                    else
                    {
                        dbContext.Entry(projeto).State = EntityState.Modified;

                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Projeto> EncontrarPorNome(String nome)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projetos.Where(u => u.Nome.Contains(nome)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
