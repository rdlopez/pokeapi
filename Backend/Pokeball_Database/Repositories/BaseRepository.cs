using Microsoft.EntityFrameworkCore;
using Pokeball_Database.Context;
using Pokeball_Database.RepositoriesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Dataplus.Database.Repositories
{
    public abstract class BaseRepository<Entity> : IBaseRepository<Entity>
        where Entity : class
    {
        public PokeballDBContext PokeballDBContext { get; }

        public BaseRepository(PokeballDBContext dataplusDBContext)
        {
            PokeballDBContext = dataplusDBContext;
        }

        public virtual Entity GetSingle(object key)
        {
            return PokeballDBContext.Set<Entity>().Find(key);
        }

        public virtual IEnumerable<Entity> GetAll()
        {
            return PokeballDBContext.Set<Entity>().ToList();
        }

        public IEnumerable<Entity> GetAll(Expression<Func<Entity, bool>> expression)
        {
            return PokeballDBContext.Set<Entity>().Where(expression).ToList();
        }

        public virtual void Update(Entity entity)
        {
            PokeballDBContext.Entry(entity).State = EntityState.Modified;            
        }

        public virtual void Create(Entity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            PokeballDBContext.Set<Entity>().Add(entity);
        }

        public virtual int Delete(Entity entity)
        {
            PokeballDBContext.Set<Entity>().Remove(entity);
            return 0;
        }       
    }
}