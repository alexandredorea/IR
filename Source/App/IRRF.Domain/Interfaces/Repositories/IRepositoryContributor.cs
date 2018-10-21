using IRRF.Domain.Entities;
using IRRF.Domain.Interfaces.Repositories.Base;

namespace IRRF.Domain.Interfaces.Repositories
{
    public interface IRepositoryContributor : IRepositoryBase<Contributor, int>
    {
        bool IsCpfRegistered(string cpf);
    }
}
