using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRUBSCHOOL.Infra.Data.Mapeamentos
{
    public class EstudanteMap : IEntityTypeConfiguration<Estudante>, IMapeamento
    {
        public void Configure(EntityTypeBuilder<Estudante> builder)
        {
            builder.ToTable("tbl_estudante")
                    .HasKey(c => c.Id);



        }
    }
}
