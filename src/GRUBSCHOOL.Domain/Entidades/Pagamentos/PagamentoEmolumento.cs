using System;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class PagamentoEmolumento : Pagamento
    {
        public decimal Valor { get; set; }
        public PagamentoEmolumento(DateTime data, decimal totalPagar, decimal totalPago, decimal valor) 
            : base(data, totalPagar, totalPago)
        {
            Valor = valor;
        }
    }
}
