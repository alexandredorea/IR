using IRRF.Domain.Interfaces.Entities.Base;
using System;

namespace IRRF.Domain.Interfaces.Entities
{
    public interface IContributor
    {
        DateTime Created { get; }
        DateTime Updated { get; }
        void SetCreated(DateTime date);
        void SetUpdated(DateTime date);
    }
}
