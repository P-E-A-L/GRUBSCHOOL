using GRUBSCHOOL.Domain.Shared.Entidades;
using System;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Periodo : EntidadeBaseNome
    {

        public new const int NomeTamanhoMaximo = 6;
   
        public Periodo(string nome) : base(nome)
        {
        }

        public Periodo(int id, string nome): base(id)
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
