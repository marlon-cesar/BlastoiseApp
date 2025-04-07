using BlastoiseApp.Domain.Entities.Common;
using System.Linq.Expressions;

namespace BlastoiseApp.Domain.Interfaces.Repositories.Common
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        ///   Busca uma entidade por Id
        /// </summary>
        /// <param name="id">Id da entidade</param>
        /// <param name="cancellationToken">Token para cancelar a requisição.</param>
        /// <returns>Task<TEntity?>?</returns>
        Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken);

        /// <summary>
        ///   Busca uma lista entidade pela expressão passada
        /// </summary>
        /// <param name="expression">Expressão Linq</param>
        /// <param name="cancellationToken">Token para cancelar a requisição.</param>
        /// <returns>Task<List<TEntity>?></returns>
        Task<List<TEntity>?> SearchAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken);

        /// <summary>
        /// Exclui uma entidade da base de dados.
        /// </summary>
        /// <param name="entity">Entidade para exclusão.</param>
        /// <param name="cancellationToken">Token para cancelar a requisição.</param>
        /// <returns></returns>
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Atualiza uma entidade na base de dados.
        /// </summary>
        /// <param name="entity">Entidade para atualização.</param>
        /// <param name="cancellationToken">Totken para cancelar a requisição.</param>
        /// <returns>Task.</returns>
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Insere uma entidade na base de dados.
        /// </summary>
        /// <param name="entity">Entidade para inclusão.</param>
        /// <param name="cancellationToken">Totken para cancelar a requisição.</param>
        /// <returns>Task.</returns>
        Task InsertAsync(TEntity entity, CancellationToken cancellationToken);

    }
}
