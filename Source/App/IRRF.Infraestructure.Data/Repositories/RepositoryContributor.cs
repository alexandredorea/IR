using IRRF.Domain.Entities;
using IRRF.Domain.Interfaces.Repositories;
using IRRF.Infraestructure.Data.Context.Base;
using IRRF.Infraestructure.Data.Repositories.Base;
using System.Linq;

namespace IRRF.Infraestructure.Data.Repositories
{
    public class RepositoryContributor : RepositoryBase<Contributor, int>, IRepositoryContributor
    {
        public RepositoryContributor(ContextBase context) : base(context)
        {
        }

        public bool IsCpfRegistered(string cpf)
        {
            return Set.Any(x => x.Cpf == cpf);
        }
    }
}
