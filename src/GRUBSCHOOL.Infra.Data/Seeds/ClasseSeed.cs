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
                new Classe("1º Classe"),
                new Classe("2º Classe"),
                new Classe("3º Classe"),
                new Classe("4º Classe"),
                new Classe("5º Classe"),
                new Classe("6º Classe"),
                new Classe("7º Classe"),
                new Classe("8º Classe"),
                new Classe("9º Classe"),
                new Classe("10º Classe"),
                new Classe("11º Classe"),
                new Classe("12º Classe"),
                new Classe("13º Classe")
            };

            modelBuilder.Entity<Classe>().HasData(classes);

        }
    }
}
