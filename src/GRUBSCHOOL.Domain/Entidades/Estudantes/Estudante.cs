﻿using GRUBSCHOOL.Domain.Shared.Entidades;

namespace GRUBSCHOOL.Domain.Entidades
{
    public class Estudante : Pessoa
    {
        public string Matricula { get; set; }

        public override void Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
