using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRUBSCHOOL.Infra.Data.Mapeamentos
{
    public class PeriodoMap : IEntityTypeConfiguration<Periodo>, IMapeamento
    {
        public void Configure(EntityTypeBuilder<Periodo> builder)
        {
            builder.ToTable("tbl_periodo")
                    .HasKey(c => c.Id);

            builder.HasIndex(m => m.Nome)
            .IsUnique();

            builder.Property(m => m.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType($"varchar({Periodo.NomeTamanhoMaximo})")
                    .IsRequired();

        }
    }
}
