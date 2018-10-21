namespace IRRF.Domain.Interfaces.Entities.Base
{
    public interface IEntityBase<TKey>
    {
        TKey Id { get; }
        void SetId(TKey id);
    }
}
