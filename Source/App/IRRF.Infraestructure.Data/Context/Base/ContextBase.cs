using IRRF.Infraestructure.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace IRRF.Infraestructure.Data.Context.Base
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> option) : base(option)
        {
            // Garante com que o banco seja criado a partir das classes 
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContributorMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
