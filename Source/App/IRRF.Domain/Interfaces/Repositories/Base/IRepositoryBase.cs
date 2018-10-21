using System.Collections.Generic;

namespace IRRF.Domain.Interfaces.Repositories.Base
{
    /// <summary>
    /// Interface genérica com restrições a tipos de parâmetros
    /// Fonte: https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
    /// </summary>
    /// <typeparam name="EntityType">Tipo de Entidade</typeparam>
    /// <typeparam name="TKey">Tipo de Chave Primária</typeparam>
    public interface IRepositoryBase<EntityType, TKey> where EntityType : class
    {
        IEnumerable<EntityType> Get();
        EntityType Get(TKey id);
        void Add(EntityType entity);
        void Update(EntityType entity);
        void Remove(EntityType entity);
        void Remove(TKey id);
    }
}
