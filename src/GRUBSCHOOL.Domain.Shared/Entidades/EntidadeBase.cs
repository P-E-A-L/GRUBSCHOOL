using Flunt.Notifications;

namespace GRUBSCHOOL.Domain.Shared.Entidades
{
    public abstract class EntidadeBase: Notifiable<Notification>
    {
        public int Id { get; protected set; }
        public abstract void Validar();

    }
}
