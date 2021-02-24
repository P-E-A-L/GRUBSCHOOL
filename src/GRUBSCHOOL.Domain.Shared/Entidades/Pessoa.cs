using System;

namespace GRUBSCHOOL.Domain.Shared.Entidades
{
    public class Pessoa : EntidadeBaseNome
    {
        public string Sexo { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
