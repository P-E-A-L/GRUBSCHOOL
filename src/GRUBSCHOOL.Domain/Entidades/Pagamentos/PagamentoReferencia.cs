using GRUBSCHOOL.Domain.Enums;
using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class PagamentoReferencia : EntidadeBaseNome
    {
        private PagamentoReferencia()
        {

        }

        public PagamentoReferencia(PagamentoReferenciaTipo tipo, string nome) : this()
        {
            Tipo = tipo;
            Nome = nome;
        }

        public PagamentoReferenciaTipo Tipo { get; set; }
        public new const int NomeTamanhoMaximo = 50;
        public override void Validar()
        {
            ValidarNome();
        }
    }
}
