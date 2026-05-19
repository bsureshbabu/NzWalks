using Microsoft.EntityFrameworkCore;
using NzWalks.API.Data;
using NzWalks.API.Models.Domain;

namespace NzWalks.API.Repositries
{
    public class SqlWalkRepoClass : IWalkRepo
    {
        private readonly NzWalksDbContext _dbcontext;

        public SqlWalkRepoClass(NzWalksDbContext dbContext)
        {
            this._dbcontext = dbContext;
        }

        public async Task<Walks> CreateAsync(Walks walks)
        {
            await _dbcontext.Walks.AddAsync(walks);
            await _dbcontext.SaveChangesAsync();
            return walks;

        }


        public async Task<List<Walks>> GetAllWalkAsync()
        {
            return await _dbcontext.Walks
                .Include(w => w.Region)
                .Include(w => w.Difficulty)
                .ToListAsync();
        }

        //public async Task<List<Walks>> GetAllAsync()
        //{
        //    return await _dbcontext.Walks.Include("Difficulty").Include("Region").ToListAsync();
        //}


    }
}
