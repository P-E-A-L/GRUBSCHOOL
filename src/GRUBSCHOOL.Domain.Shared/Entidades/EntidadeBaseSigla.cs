using Flunt.Validations;

namespace GRUBSCHOOL.Domain.Shared.Entidades
{
    public abstract class EntidadeBaseSigla : EntidadeBaseNome
    {

        protected EntidadeBaseSigla() { }

        protected EntidadeBaseSigla(int id) : base(id) { }

        protected EntidadeBaseSigla(string sigla)
        {
            Sigla = sigla;
            ValidarSigla();
        }

        public string Sigla { get; protected set; }
        public const int SiglaTamanhoMaximo = 10;

        protected void ValidarSigla()
        {
            AddNotifications(new Contract<EntidadeBaseSigla>()
                 .IsLowerOrEqualsThan(SiglaTamanhoMaximo, Sigla.Length, nameof(Sigla), $"'{nameof(Sigla)}' tem que ter no máximo {SiglaTamanhoMaximo} caracteres.")
             );
        }
    }
}
