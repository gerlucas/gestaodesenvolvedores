using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaBD
{
    [Table("tabelacredencial")]
    public class Credencial
    {
        public Int64 Id { get; set; }

        public const String SALT = "1G3LuC4s_";

        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }

        private String _senha;

        [Required]
        [StringLength(64)]
        public String Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                if (value.Length >= 8 && value.Length <= 12)
                {
                    _senha = ComputeSHA256(value, SALT);
                }
                else if (value.Length == 64)
                {
                    _senha = value;
                }
            }
        }

        public Boolean Administrador { get; set; }
        public Boolean Ativo { get; set; }

        [Required]
        public Desenvolvedor Desenvolvedor { get; set; }

        public List<Alocacao> Alocacoes { get; set; }

        #region Hashing
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion

        public Credencial()
        {

        }
        public Credencial(String email, String senha, Boolean ativo, Boolean adm)
        {
            Email = email;
            Senha = senha;
            Ativo = ativo;
            Administrador = adm;
        }
    }
}
