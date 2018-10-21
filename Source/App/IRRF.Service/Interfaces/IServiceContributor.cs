using IRRF.Service.DTO;
using System.Collections.Generic;

namespace IRRF.Service.Interfaces
{
    public interface IServiceContributor
    {
        IEnumerable<ContributorDto> CalculateIncomeTax(decimal salary);
    }
}
