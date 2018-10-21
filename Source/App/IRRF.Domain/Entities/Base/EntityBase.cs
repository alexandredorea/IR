using Flunt.Notifications;
using IRRF.Domain.Interfaces.Entities.Base;

namespace IRRF.Domain.Entities.Base
{
    public abstract class EntityBase<TKey> : Notifiable, IEntityBase<TKey>
    {
        public TKey Id { get; private set; }

        public void SetId(TKey id)
        {
            Id = id;
        }
    }
}
