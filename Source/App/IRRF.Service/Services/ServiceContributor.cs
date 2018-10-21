using AutoMapper;
using IRRF.Domain.Entities;
using IRRF.Domain.Interfaces.Repositories;
using IRRF.Service.DTO;
using IRRF.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace IRRF.Service.Services
{
    public class ServiceContributor : IServiceContributor
    {
        private readonly IRepositoryContributor _repository;
        private readonly IMapper _mapper;

        public ServiceContributor(IRepositoryContributor repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<ContributorDto> CalculateIncomeTax(decimal salary)
        {
            var incomeTax = new IncomeTax(salary);
            var contributors = _repository.Get().ToList();
            contributors.ForEach(x => incomeTax.CalculateIncomeTax(x));
            contributors = contributors.OrderBy(x => x.IncomeTax).ThenBy(x => x.Name).ToList();
            return _mapper.Map<List<ContributorDto>>(contributors);
        }
    }
}
