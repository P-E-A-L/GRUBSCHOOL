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
                new Ciclo("Ensino Primário"),
                new Ciclo("Iº Ciclo"),
                new Ciclo("IIº Ciclo"),
                new Ciclo ("Ensino Médio")
            };

            modelBuilder.Entity<Ciclo>().HasData(ciclo);

        }
    }
}
