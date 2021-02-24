using Flunt.Validations;
using GRUBSCHOOL.Domain.Shared.Entidades;
using System;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class AnoLectivo : EntidadeBase
    {
        public int Ano { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }

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
