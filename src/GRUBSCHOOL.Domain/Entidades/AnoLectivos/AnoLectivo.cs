using Flunt.Validations;
using GRUBSCHOOL.Domain.Shared.Entidades;
using System;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class AnoLectivo : Entidade
    {
        public int Ano { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataTermino { get; private set; }

        public AnoLectivo(int ano, DateTime dataInicio, DateTime dataTermino)
        {
            Ano = ano;
            DataInicio = dataInicio;
            DataTermino = dataTermino;

            Validar();
        }


        public override void Validar()
        {
            ValidarAno();
            ValidarDataInicio();
            ValidarDataFim();
        }

        private void ValidarAno()
        {
            AddNotifications(new Contract<AnoLectivo>()
                .Requires()
                .IsGreaterThan(0, Ano, nameof(Ano), $"'{nameof(Ano)}' tem que ser maio que zero (0).")
                );
        }

        private void ValidarDataInicio()
        {
            AddNotifications(new Contract<AnoLectivo>()
                .Requires()
                .IsGreaterOrEqualsThan(DataInicio, DataTermino, nameof(DataInicio), $"'A data de início não pode ser superior ou igual a data de término.")
                );
        }

        private void ValidarDataFim()
        {
            AddNotifications(new Contract<AnoLectivo>()
                .Requires()
                );
        }

    }
}
