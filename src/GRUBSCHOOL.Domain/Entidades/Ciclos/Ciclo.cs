using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Ciclo : EntidadeBaseNome
    {
        public new  const int NomeTamanhoMaximo = 15;

        private Ciclo() { }

        public Ciclo(string nome) : base (nome)
        {
        }

        public Ciclo(int id, string nome) : base(id)
        {
            Nome = nome;

            Validar();
        }

        public override void Validar()
        {
            ValidarNome();
        }
    }
}