using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Classe : EntidadeBaseNome
    {

        public new const int NomeTamanhoMaximo = 10;
        private Classe()
        {

        }

        public Classe(string nome): base(nome)
        {
        }

        public Classe(int id, string nome): base(id)
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
