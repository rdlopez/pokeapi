using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Pokeball_Database.RepositoriesContracts
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        //PokeballDBContext PokeballDBContext { get; }
        Entity GetSingle(object key);
        IEnumerable<Entity> GetAll();
        IEnumerable<Entity> GetAll(Expression<Func<Entity, bool>> expression);
        void Update(Entity entity);
        void Create(Entity entity);
        int Delete(Entity entity);
    }
}
