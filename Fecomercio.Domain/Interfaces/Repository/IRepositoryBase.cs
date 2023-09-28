using System.Linq.Expressions;

namespace Fecomercio.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity>
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
