using Lab3.DAL.Entities;

namespace Lab3.DAL.Repositories
{
    public interface IRepositoryBase<TEntity, TKey>
        where TEntity : IdentifiedEntity<TKey>
        where TKey : notnull
    {
        Task<TEntity> CreateAsync(TEntity entity);
        TEntity Delete(TEntity entity);
        Task<TEntity?> GetEntityByIdAsync(TKey key);
        Task<List<TEntity>> GetEntitiesAsync();
        int Save();
        Task<int> SaveAsync();
        TEntity Update(TEntity entity);
    }
}