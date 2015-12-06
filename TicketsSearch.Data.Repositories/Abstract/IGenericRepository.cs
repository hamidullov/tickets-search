using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TicketsSearch.Data.Models;

namespace TicketsSearch.Data.Repositories.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
                               Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                               params Expression<Func<TEntity,object>>[] includeProperties);

        void Insert(TEntity entity);
        
        void Delete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);

        void Save();

        Task SaveAsync();
    }
}