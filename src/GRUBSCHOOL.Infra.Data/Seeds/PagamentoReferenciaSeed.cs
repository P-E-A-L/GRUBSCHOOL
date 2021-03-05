using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GRUBSCHOOL.Infra.Data.Seeds
{
    public class PagamentoReferenciaSeed
    {
        class PagamentoReferencia
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int Tipo { get; set; }

            public PagamentoReferencia(int id, string nome, int tipo)
            {
                Id = id;
                Nome = nome;
                Tipo = tipo;
            }
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            var ciclo = new List<PagamentoReferencia>
            {
                //new PagamentoReferencia(PagamentoReferenciaTipo.MatriculaConfirmacao, "Matrícula-Confirmação"),
                //new PagamentoReferencia(PagamentoReferenciaTipo.Mensalidade, "Mensalidade"),
                //new PagamentoReferencia(PagamentoReferenciaTipo.Emolumento, "Cartão de Estudante"),
                //new PagamentoReferencia(PagamentoReferenciaTipo.Emolumento, "Certificado"),
                //new PagamentoReferencia(PagamentoReferenciaTipo.Emolumento, "Declaração Sem Notas"),
                //new PagamentoReferencia(PagamentoReferenciaTipo.Emolumento, "Declaração Com Notas")
            };

            modelBuilder.Entity<PagamentoReferencia>().HasData(ciclo);

        }
    }
}
