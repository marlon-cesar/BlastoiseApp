using BlastoiseApp.Data.Contexts;
using BlastoiseApp.Domain.Entities.Common;
using BlastoiseApp.Domain.Interfaces.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace BlastoiseApp.Data.Repositories.Common
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        protected BlastoiseAppDbContext Context { get; }

        protected RepositoryBase(BlastoiseAppDbContext context)
        {
            Context = context;
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken) =>
             await Context.Set<TEntity>().Where(x => x.Id == id).FirstOrDefaultAsync(cancellationToken);

        public virtual async Task<List<TEntity>?> SearchAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken) =>
            await Context.Set<TEntity>().Where(expression).ToListAsync(cancellationToken);


        public virtual async Task InsertAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await Context.Set<TEntity>().AddAsync(entity, cancellationToken);
            await Context.SaveChangesAsync(cancellationToken);
        }


        public virtual async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            Context.Set<TEntity>().Update(entity);
            await Context.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken)
        {
            Context.Set<TEntity>().Remove(entity);
            await Context.SaveChangesAsync(cancellationToken);
        }
        
    }
}
