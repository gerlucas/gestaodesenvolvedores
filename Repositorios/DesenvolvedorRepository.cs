using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaBD
{
    public class DesenvolvedorRepository
    {
        public static void Salvar(Desenvolvedor dev)
        { 
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (dev.Id == 0)
                    {
                        dbContext.Devs.Add(dev);
                    }
                    else
                    {

                        dbContext.Entry(dev.Credencial).State = EntityState.Modified;

                        dbContext.Devs.Attach(dev);

                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public static Desenvolvedor EncontrarEmail(String email)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Devs
                        .Include("Credencial")
                        .Where(u => u.Credencial.Email == email)
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Desenvolvedor> EncontrarPorNome(String nome)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Devs.Include("Credencial")
                        .Where(u => u.Nome.Contains(nome))
                        .ToList<Desenvolvedor>();
                }
            }
            catch (Exception)
            {
                throw;

            }
        }
        
    }
}

