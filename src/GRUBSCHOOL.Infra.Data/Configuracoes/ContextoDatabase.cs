using Flunt.Notifications;
using GRUBSCHOOL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GRUBSCHOOL.Infra.Data.Configuracoes
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase() { }

        public ContextoDatabase(DbContextOptions<ContextoDatabase> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.Entity<Notification>()
                        .HasNoKey()
                        .Ignore(c => c.Key)
                        .Ignore(e => e.Message);

            ConfiguracaoMapeamento.AplicarConfiguracao(modelBuilder);
            ConfiguracaoSeeds.AplicarConfiguracao(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.MySQLConfiguration();

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<AnoLectivo> AnoLectivos { get; set; }
        public virtual DbSet<Ciclo> Ciclos { get; set; }
        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<CursoTipo> CursoTipos { get; set; }
        public virtual DbSet<Periodo> Periodos { get; set; }
    }
}
