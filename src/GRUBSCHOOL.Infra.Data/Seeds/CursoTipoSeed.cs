using GRUBSCHOOL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GRUBSCHOOL.Infra.Data.Seeds
{
    public static class CursoTipoSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var cursoTipos = new List<CursoTipo>
            {
                new CursoTipo(1,"Técnico"),
                new CursoTipo(2,"Saúde"),
                new CursoTipo(3,"PUNIV")
            };

            modelBuilder.Entity<CursoTipo>().HasData(cursoTipos);

        }
    }
}
