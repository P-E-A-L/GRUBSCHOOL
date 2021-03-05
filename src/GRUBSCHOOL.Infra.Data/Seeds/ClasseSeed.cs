using GRUBSCHOOL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GRUBSCHOOL.Infra.Data.Seeds
{
    public static class ClasseSeed
    {
       
        public static void Seed(ModelBuilder modelBuilder)
        {
            var classes = new List<Classe>
            {
                new Classe("Iniciação"),
                new Classe("1ª Classe"),
                new Classe("2ª Classe"),
                new Classe("3ª Classe"),
                new Classe("4ª Classe"),
                new Classe("5ª Classe"),
                new Classe("6ª Classe"),
                new Classe("7ª Classe"),
                new Classe("8ª Classe"),
                new Classe("9ª Classe"),
                new Classe("10ª Classe"),
                new Classe("11ª Classe"),
                new Classe("12ª Classe"),
                new Classe("13ª Classe")
            };

            modelBuilder.Entity<Classe>().HasData(classes);

        }
    }
}
