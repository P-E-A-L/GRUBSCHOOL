using Flunt.Notifications;
using System;

namespace GRUBSCHOOL.Domain.Shared.Entidades
{
    public abstract class Entidade: Notifiable<Notification>
    {
        public int Id { get; private set; }
        public abstract void Validar();

        protected Entidade(int id)
        {
            Id = id;
        }

        protected Entidade()
        {
        }

       
    }
}
