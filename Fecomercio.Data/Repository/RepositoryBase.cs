using Fecomercio.Data.Context;
using Fecomercio.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Fecomercio.Data.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected FecomercioContext _context;

        public RepositoryBase(FecomercioContext context)
        {
            _context = context;
        }

        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }
        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }
    }
}
