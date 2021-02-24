using GRUBSCHOOL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GRUBSCHOOL.Infra.Data.Seeds
{
    public static class PeriodoSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var periodos = new List<Periodo>
            {
                new Periodo("Manhã"),
                new Periodo("Tarde"),
                new Periodo("Noite")
            };

            modelBuilder.Entity<Periodo>().HasData(periodos);

        }
    }
}
