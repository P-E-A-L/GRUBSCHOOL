using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRUBSCHOOL.Infra.Data.Mapeamentos
{
    public class AnoLectivoMap : IEntityTypeConfiguration<AnoLectivo>, IMapeamento
    {
        public void Configure(EntityTypeBuilder<AnoLectivo> builder)
        {
            builder.ToTable("ano_lectivos")
                    .Ignore(c => c.Id)
                    .HasNoKey();

            builder.HasIndex(m => m.Ano)
                 .IsUnique()
                 .IsUnique();

        }
    }
}
