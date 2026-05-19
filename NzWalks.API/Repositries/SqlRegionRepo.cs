using Microsoft.EntityFrameworkCore;
using NzWalks.API.Data;
using NzWalks.API.Models.Domain;

namespace NzWalks.API.Repositries
{
    public class SqlRegionRepo : IRepositry
    {
        private readonly NzWalksDbContext _dbcontext;

            public SqlRegionRepo(NzWalksDbContext dbContext)
        {
            this._dbcontext   = dbContext;
        }

        public async Task<List<Regions>> GetAllRegionsAsync()
        {
            // Implementation for fetching all regions from SQL database
            return await _dbcontext.Regions.ToListAsync();
        }
        public async Task<Regions> GetRegionByIdAsync(Guid id)
        {
            // Implementation for fetching a region by ID from SQL database
            return await _dbcontext.Regions.FirstOrDefaultAsync(x=>x.Id==id);
        }
    }
}
