using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Ciclo : EntidadeBaseNome
    {
        public new  const int NomeTamanhoMaximo = 15;

        private Ciclo()
        {

        }

        public Ciclo(string nome)
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