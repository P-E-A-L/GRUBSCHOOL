using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class CursoTipo : EntidadeBaseNome
    {
        private CursoTipo()
        {

        }

        public CursoTipo(string nome) : this()
        {
            Nome = nome;
        }


        public override void Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
