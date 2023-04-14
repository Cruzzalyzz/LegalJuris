using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalJuris
{
    public class Contexto : DbContext
    {
        public Contexto() : base("LegalJurisContext") 
        {
            Database.SetInitializer<Contexto>(null);
        }

        public DbSet<Processo> ObjetoProcesso{get; set;}
        public DbSet<Cliente> ObjetoCliente { get; set; }
        public DbSet<Caso> ObjetoCaso { get; set; }
        public DbSet<Comarca> ObjetoComarca { get; set; }
        public DbSet<Foro> ObjetoForo { get; set; }
        public DbSet<Vara> ObjetoVara { get; set; }
       public DbSet<Responsavel> ObjetoResponsavel { get; set; }
    }

    

}
