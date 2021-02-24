using GRUBSCHOOL.Domain.Shared.Entidades;
using System.Collections.Generic;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Curso : EntidadeBaseSigla
    {
        public int CursoTipoId { get; private set; }
        public virtual CursoTipo CursoTipo { get; private set; }

        private Curso()
        {
            
        }

        public Curso(string nome, string sigla, int cursoTipoId) : this()
        {
            Nome = nome;
            Sigla = sigla;
            CursoTipoId = cursoTipoId;
        }

        public override void Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
