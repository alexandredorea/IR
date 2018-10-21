using IRRF.Domain.Entities.Base;
using IRRF.Domain.Interfaces.Repositories.Base;
using IRRF.Infraestructure.Data.Context.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IRRF.Infraestructure.Data.Repositories.Base
{
    public class RepositoryBase<EntityType, TKey> : IRepositoryBase<EntityType, TKey> where EntityType : EntityBase<TKey>
    {
        protected readonly ContextBase Context;
        protected readonly DbSet<EntityType> Set;

        public RepositoryBase(ContextBase context)
        {
            Context = context;
            Set = Context.Set<EntityType>();
        }

        public void Add(EntityType entity)
        {
            Set.Add(entity);
            Context.SaveChanges();
        }

        public IEnumerable<EntityType> Get()
        {
            return Set.ToList();
        }

        public EntityType Get(TKey id)
        {
            return Set.Find(id);
        }

        public void Remove(EntityType entity)
        {
            Set.Remove(entity);
            Context.SaveChanges();
        }

        public void Remove(TKey id)
        {
            Set.Remove(this.Get(id));
            Context.SaveChanges();
        }

        public void Update(EntityType entity)
        {
            Set.Update(entity);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}