using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Model.Global.Repositories
{
    public interface IRepository<TEntity, TId>
    {
        TEntity Get(TId id);
        IEnumerable<TEntity> Get();
        TId Create(TEntity entity);
        bool Update(TId id, TEntity entity);
        bool Delete(TId id);
    }
}
