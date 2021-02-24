using GRUBSCHOOL.Domain.Enums;
using GRUBSCHOOL.Domain.Shared.Entidades;
using System;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Pagamento : EntidadeBase
    {
        public EstadoPagamento Estado { get; private set; }
        public DateTime Data { get; private set; }
        public decimal TotalPagar { get; private set; }
        public decimal TotalPago { get; private set; }
        public decimal Saldo { get; private set; }
        public string Observacao { get; private set; }

        private Pagamento()
        {

        }

        public Pagamento(DateTime data, decimal totalPagar, decimal totalPago)
        {
            Data = data;
            TotalPagar = totalPagar;
            TotalPago = totalPago;
            Saldo = totalPagar - totalPago;

            Validar();
        }

        public override void Validar()
        {
            throw new System.NotImplementedException();
        }

        public void SetObservacao(string observacao)
        {
            Observacao = observacao;
        }
    }
}
