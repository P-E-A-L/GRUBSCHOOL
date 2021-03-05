using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRUBSCHOOL.Infra.Data.Mapeamentos
{
    public class ClasseMap : IEntityTypeConfiguration<Classe>, IMapeamento
    {
        public void Configure(EntityTypeBuilder<Classe> builder)
        {
            builder.ToTable("classes")
                    .HasKey(c => c.Id);

            builder.HasIndex(m => m.Nome)
                .IsUnique();

            builder.Property(m => m.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType($"varchar({Classe.NomeTamanhoMaximo})")
                    .IsRequired();

        }
    }
}
