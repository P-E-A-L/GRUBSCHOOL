using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRUBSCHOOL.Infra.Data.Mapeamentos
{
    public class CicloMap : IEntityTypeConfiguration<Ciclo>, IMapeamento
    {
        public void Configure(EntityTypeBuilder<Ciclo> builder)
        {
            builder.ToTable("tbl_ciclo")
                    .HasKey(c => c.Id);

            builder.HasIndex(m => m.Nome)
                .IsUnique();

            builder.Property(m => m.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType($"varchar({Ciclo.NomeTamanhoMaximo})")
                    .IsRequired();

        }
    }
}
