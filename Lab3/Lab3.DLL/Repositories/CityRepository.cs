using Lab3.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab3.DAL.Repositories;

public class CityRepository : RepositoryBase<City, long>, IRepositoryBase<City, long>
{
    public CityRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }

    public override async Task<City?> GetEntityByIdAsync(long key)
    {
        return await table.Include(t => t.Country).FirstAsync(e => e.Id.Equals(key));
    }
}
