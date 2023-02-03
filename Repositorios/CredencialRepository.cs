using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaBD
{
    public class CredencialRepository
    {
        public static Desenvolvedor AutenticarDev(String email, String senha)
        {
            Desenvolvedor dev = DesenvolvedorRepository.EncontrarEmail(email);

            if (dev != null)
            {
                String senhanobd = dev.Credencial.Senha;
                
                if (senhanobd == Credencial.ComputeSHA256(senha, Credencial.SALT))
                {
                    return dev;
                }
                else
                {
                    MessageBox.Show("Senha incorreta.", "SENHA INCORRETA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("E-mail incorreto.", "E-MAIL INCORRETO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private static string ComputeSHA256(string senha, object SALT)
        {
            throw new NotImplementedException();
        }
    }
}
