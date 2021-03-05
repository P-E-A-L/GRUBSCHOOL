using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class CursoTipo : EntidadeBaseNome
    {
        public new const int NomeTamanhoMaximo = 7;
       
        public CursoTipo(string nome) : base(nome)
        {
        }
        
        public CursoTipo(int id, string nome) : base(id)
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
