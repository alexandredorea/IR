using AutoMapper;
using IRRF.Domain.Entities;
using IRRF.Service.DTO;

namespace IRRF.Infraestructure.Crosscutting.AutoMapper.Configurations
{
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<Contributor, ContributorDto>();
        }
    }
}