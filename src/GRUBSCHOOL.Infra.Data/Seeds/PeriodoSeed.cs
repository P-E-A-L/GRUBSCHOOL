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
                new Periodo(1,"Manhã"),
                new Periodo(2, "Tarde"),
                new Periodo(3, "Noite")
            };

            modelBuilder.Entity<Periodo>().HasData(periodos);

        }
    }
}
