using Flunt.Validations;
using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Curso : EntidadeBaseSigla
    {
        public int CursoTipoId { get; private set; }
        public virtual CursoTipo CursoTipo { get; private set; }

        public Curso(int id, string nome, string sigla, int cursoTipoId) : base(id)
        {
            Nome = nome;
            Sigla = sigla;
            CursoTipoId = cursoTipoId;
            Validar();
        }

        public Curso(string nome, string sigla, int cursoTipoId) 
        {
            Nome = nome;
            Sigla = sigla;
            CursoTipoId = cursoTipoId;
            Validar();
        }

        public override void Validar()
        {
            ValidarNome();
            ValidarSigla();
            ValidarCursoTipoId();
        }

        private void ValidarCursoTipoId()
        {
            AddNotifications(new Contract<Curso>()
                            .Requires()
                            .AreNotEquals(0, CursoTipoId, "Tem que selecionar o tipo de curso.")
                            .AreNotEquals(0, CursoTipoId, "Tem que selecionar o tipo de curso.")
                        );
        }
    }
}
