using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GRUBSCHOOL.Infra.Data.Mapeamentos
{
    public class CursoMap : IEntityTypeConfiguration<Curso>, IMapeamento
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("tbl_curso")
                    .HasKey(c => c.Id);
            
            builder.HasIndex(m => m.Nome)
                    .IsUnique();

            builder.Property(m => m.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType($"varchar({Curso.NomeTamanhoMaximo})")
                    .IsRequired();

            builder.Property(m => m.Sigla)
                    .HasColumnName("Sigla")
                    .HasColumnType($"varchar({Curso.SiglaTamanhoMaximo})")
                    .IsRequired();

            //builder.HasAlternateKey(c => c.CursoTipoId);
            //builder.HasOne(c=>c.CursoTipo).WithMany(fk => fk.)

        }
    }
}
