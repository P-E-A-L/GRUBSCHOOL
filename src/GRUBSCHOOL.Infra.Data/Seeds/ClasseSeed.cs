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
                new Classe(1,"Iniciação"),
                new Classe(2,"1ª Classe"),
                new Classe(3,"2ª Classe"),
                new Classe(4,"3ª Classe"),
                new Classe(5,"4ª Classe"),
                new Classe(6,"5ª Classe"),
                new Classe(7,"6ª Classe"),
                new Classe(8,"7ª Classe"),
                new Classe(9,"8ª Classe"),
                new Classe(10,"9ª Classe"),
                new Classe(11,"10ª Classe"),
                new Classe(12,"11ª Classe"),
                new Classe(13,"12ª Classe"),
                new Classe(14,"13ª Classe")
            };

            modelBuilder.Entity<Classe>().HasData(classes);

        }
    }
}
