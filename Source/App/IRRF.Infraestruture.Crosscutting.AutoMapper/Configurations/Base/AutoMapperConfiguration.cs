using AutoMapper;

namespace IRRF.Infraestructure.Crosscutting.AutoMapper.Configurations.Base
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration Configure()
        {
            return new MapperConfiguration(configuration =>
            {
                configuration.AddProfile(new EntityToDto());
                configuration.AddProfile(new DtoToEntity());
            });
        }
    }
}