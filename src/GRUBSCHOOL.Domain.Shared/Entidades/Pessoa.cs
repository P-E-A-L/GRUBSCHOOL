using System;

namespace GRUBSCHOOL.Domain.Shared.Entidades
{
    public abstract class Pessoa : EntidadeBaseNome
    {
        public string Sexo { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}
