using GRUBSCHOOL.Domain.Shared.Entidades;
using System;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Periodo : EntidadeBaseNome
    {

        public new const int NomeTamanhoMaximo = 6;
        private Periodo() { }

        public Periodo(string nome)
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
