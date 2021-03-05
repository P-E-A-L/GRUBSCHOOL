using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class CursoTipo : EntidadeBaseNome
    {
        public new const int NomeTamanhoMaximo = 7;
        private CursoTipo()
        {

        }

        public CursoTipo(string nome) : this()
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
