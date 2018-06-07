using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Dominio;

namespace Tcc.DayHappy.Data.Repositorios
{
   /* public class Repository<TEntity> : IRepository<TEntity>
    {
        protected readonly string ConnectionString;

        public Repository(ConnectionString context)
        {
            _context = context;
        }

        public virtual TEntity GetById(int id)
        {
            var query = _context.Set<TEntity>().Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }

        public virtual IEnumerable<TEntity> All()
        {
            var query = _context.Set<TEntity>();

            if (query.Any())
                return query.ToList();

            return new List<TEntity>();
        }

        public virtual void Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

    }*/
}
