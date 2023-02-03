using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AtividadeAvaliativaBD
{
    public class Repository : DbContext
    {
        private static MySqlConnection _databaseConnection;

        public DbSet<Desenvolvedor> Devs { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Alocacao> Alocacoes { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }


        public Repository() : base(GetDbConnection(), false)
        {

            if (Database.CreateIfNotExists())
            {

                Repository dbContext = new Repository();


                Desenvolvedor devpadrao = new Desenvolvedor("George Lucas", new DateTime(2005, 07, 08), 'S');
                Credencial credpadrao = new Credencial("glucas@gmail.com", "12345678", true, true);

                credpadrao.Desenvolvedor = devpadrao;
                devpadrao.Credencial = credpadrao;


                dbContext.Devs.Add(devpadrao);
                dbContext.SaveChanges();

            }
        }

        public static MySqlConnection GetDbConnection()
        {
            if (_databaseConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["GestaoDesenvolvedoresString"].ConnectionString;
                _databaseConnection = new MySqlConnection(connectionString);
            }
            return _databaseConnection;
        }
    }
}