using LACore.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LACore.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Save();
    }
}
