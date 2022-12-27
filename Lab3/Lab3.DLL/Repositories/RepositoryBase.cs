using Lab3.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab3.DAL.Repositories;

public abstract class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey> where TEntity : IdentifiedEntity<TKey> where TKey : notnull
{
    protected readonly AppDbContext appDbContext;
    protected readonly DbSet<TEntity> table;

    public RepositoryBase(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
        table = appDbContext.Set<TEntity>();
    }

    public virtual async Task<List<TEntity>> GetEntitiesAsync()
    {
        return await table.ToListAsync();
    }    
    
    public virtual async Task<TEntity?> GetEntityByIdAsync(TKey key)
    {
        return await table.FirstAsync(e => e.Id.Equals(key));
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        return (await table.AddAsync(entity)).Entity;
    }

    public virtual TEntity Update(TEntity entity)
    {
        return table.Update(entity).Entity;
    }

    public virtual TEntity Delete(TEntity entity)
    {
        return table.Remove(entity).Entity;
    }

    public async Task<int> SaveAsync()
    {
        return await appDbContext.SaveChangesAsync();
    }

    public int Save()
    {
        return appDbContext.SaveChanges();
    }
}
