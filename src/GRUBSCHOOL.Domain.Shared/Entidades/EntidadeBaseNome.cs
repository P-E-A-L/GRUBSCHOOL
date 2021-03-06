﻿using Flunt.Notifications;
using Flunt.Validations;

namespace GRUBSCHOOL.Domain.Shared.Entidades
{
    public abstract class EntidadeBaseNome : Entidade
    {
        public string Nome { get; protected set; }
        public const int NomeTamanhoMaximo = 50;

        protected EntidadeBaseNome() { }

        protected EntidadeBaseNome(int id) : base(id) { }

        protected EntidadeBaseNome(string nome)
        {
            Nome = nome;
            ValidarNome();
        }

        protected void ValidarNome()
        {
            AddNotifications(new Contract<EntidadeBaseNome>()
                 .Requires()
                 .IsNotEmpty(Nome, Nome, "O nome tem de ser preenchido.")
                 .IsLowerOrEqualsThan(NomeTamanhoMaximo, Nome.Length, nameof(Nome), $"O tem que ter no máximo {NomeTamanhoMaximo} caracteres.")
             );
        }

    }
}
