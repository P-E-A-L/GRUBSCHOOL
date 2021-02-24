using GRUBSCHOOL.Domain.Entidades;
using GRUBSCHOOL.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GRUBSCHOOL.Infra.Data.Seeds
{
    public class PagamentoReferenciaSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var ciclo = new List<PagamentoReferencia>
            {
                new PagamentoReferencia(PagamentoReferenciaTipo.MatriculaConfirmacao, "Matrícula-Confirmação"),
                new PagamentoReferencia(PagamentoReferenciaTipo.Mensalidade, "Mensalidade"),
                new PagamentoReferencia(PagamentoReferenciaTipo.Emolumento, "Cartão de Estudante"),
                new PagamentoReferencia(PagamentoReferenciaTipo.Emolumento, "Certificado"),
                new PagamentoReferencia(PagamentoReferenciaTipo.Emolumento, "Declaração Sem Notas"),
                new PagamentoReferencia(PagamentoReferenciaTipo.Emolumento, "Declaração Com Notas")
            };

            modelBuilder.Entity<PagamentoReferencia>().HasData(ciclo);

        }
    }
}
