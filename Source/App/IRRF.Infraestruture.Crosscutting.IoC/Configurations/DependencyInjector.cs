using IRRF.Domain.Interfaces.Repositories;
using IRRF.Infraestructure.Data.Context.Base;
using IRRF.Infraestructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IRRF.Infraestruture.Crosscutting.IoC.Configurations
{
    public class DependencyInjector
    {
        public static void Inject(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextBase>(options => options
                                                          .UseSqlServer(configuration
                                                                        .GetConnectionString("DefaultConnection")
                                                                       ));

            //services.AddScoped<IContribuinteService, ContribuinteService>();

            services.AddScoped<IRepositoryContributor, RepositoryContributor>();
            services.AddScoped<ContextBase>();

        }
    }
}
