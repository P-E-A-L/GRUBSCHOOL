using GRUBSCHOOL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GRUBSCHOOL.Infra.Data.Seeds
{

    public static class CicloSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var ciclo = new List<Ciclo>
            {
                new Ciclo(1,"Ensino Primário"),
                new Ciclo(2, "Iº Ciclo"),
                new Ciclo(3, "IIº Ciclo"),
                new Ciclo (4, "Ensino Médio")
            };

            modelBuilder.Entity<Ciclo>().HasData(ciclo);

        }
    }
}
