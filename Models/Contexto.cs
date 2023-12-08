using Microsoft.EntityFrameworkCore;

namespace ProjetoFinalPietra.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
         public DbSet<Cidade> Cidade {get; set;}

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Colaborador> Colaborador { get; set; }

        public DbSet<Estado> Estado { get; set; }

        public DbSet<Localrealizacao> Localrealizacao { get; set; }

        public DbSet<Procedimento> Procedimento { get; set; }

        public DbSet<Procedimentorealizado> Procedimentorealizado { get; set; }

        public DbSet<Tipocolaborador> Tipocolaborador { get; set; }

        public DbSet<Tipoprocedimento> Tipoprocedimento { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
