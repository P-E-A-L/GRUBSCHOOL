using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Classe : EntidadeBaseNome
    {

        public new const int NomeTamanhoMaximo = 50;
        private Classe()
        {

        }
        public Classe(string nome)
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
