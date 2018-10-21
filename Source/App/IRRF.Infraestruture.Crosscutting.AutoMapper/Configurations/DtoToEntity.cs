using AutoMapper;
using IRRF.Domain.Entities;
using IRRF.Service.DTO;

namespace IRRF.Infraestructure.Crosscutting.AutoMapper.Configurations
{
    public class DtoToEntity : Profile
    {
        public DtoToEntity()
        {
            CreateMap<ContributorDto, Contributor>();
        }
    }
}