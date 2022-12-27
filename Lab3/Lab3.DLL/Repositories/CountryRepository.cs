using Lab3.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab3.DAL.Repositories;

public class CountryRepository : RepositoryBase<Country, long>, IRepositoryBase<Country, long>
{
    public CountryRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }
}
