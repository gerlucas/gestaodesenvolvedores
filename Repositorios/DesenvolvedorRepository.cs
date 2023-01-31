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
        public static void Salvar(Desenvolvedor usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (usuario.Id == 0)
                    {
                        dbContext.Devs.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State
                            = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("E-mail já utilizado.", "E-MAIL REPETIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    return dbContext.Devs
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

