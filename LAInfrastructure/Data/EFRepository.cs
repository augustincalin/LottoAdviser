using LACore.Common;
using LACore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LAInfrastructure.Data
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _entities;
        public EFRepository(DbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public TEntity Get(int id)
        {
            return _entities.SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities;
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
