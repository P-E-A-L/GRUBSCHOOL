using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRUBSCHOOL.Infra.Data.Mapeamentos
{
    public class CursoTipoMap : IEntityTypeConfiguration<CursoTipo>, IMapeamento
    {
        public void Configure(EntityTypeBuilder<CursoTipo> builder)
        {
            builder.ToTable("curso_tipos")
                    .HasKey(c => c.Id);

            builder.HasIndex(m => m.Nome)
                .IsUnique();

            builder.Property(m => m.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType($"varchar({CursoTipo.NomeTamanhoMaximo})")
                    .IsRequired();

        }
    }
}
