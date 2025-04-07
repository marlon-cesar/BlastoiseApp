namespace BlastoiseApp.Domain.Interfaces.Repositories.Common
{
	public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
	{
		/// <summary>
		///   Busca uma entidade por Id
		/// </summary>
		/// <param name="id">Id da entidade</param>		
		/// <returns>Task<TEntity?>?</returns>
		Task<TEntity?> GetByIdAsync(int id);

		/// <summary>
		///   Busca uma lista entidade pela expressão passada
		/// </summary>
		/// <param name="expression">Expressão Linq</param>		
		/// <returns>Task<List<TEntity>?></returns>
		Task<List<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> expression);

		/// <summary>
		/// Exclui uma entidade da base de dados.
		/// </summary>
		/// <param name="entity">Entidade para exclusão.</param>		
		/// <returns></returns>
		Task DeleteAsync(TEntity entity);

		/// <summary>
		/// Atualiza uma entidade na base de dados.
		/// </summary>
		/// <param name="entity">Entidade para atualização.</param>
		/// <returns>Task.</returns>
		Task UpdateAsync(TEntity entity);

		/// <summary>
		/// Insere uma entidade na base de dados.
		/// </summary>
		/// <param name="entity">Entidade para inclusão.</param>
		/// <returns>Task.</returns>
		Task InsertAsync(TEntity entity);

	}
}
