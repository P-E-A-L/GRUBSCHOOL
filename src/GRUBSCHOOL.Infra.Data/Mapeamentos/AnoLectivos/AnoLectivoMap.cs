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
            builder.ToTable("tbl_ano_lectivo")
                    .Ignore(c=>c.Id)
                    .HasNoKey()
                    .HasAlternateKey(c=>c.Ano);

            builder.HasIndex(m => m.Ano)
                 .IsUnique()
                 .IsUnique();



        }
    }
}
