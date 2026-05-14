using Microsoft.EntityFrameworkCore;
using NzWalks.API.Models.Domain;

namespace NzWalks.API.Data
{
    public class NzWalksDbContext : DbContext
    {
        public NzWalksDbContext(DbContextOptions<NzWalksDbContext> options) : base(options)
        {
        }   

        public DbSet<Regions> Regions { get; set; }
        public DbSet<Walks> Walks { get; set; }
        public DbSet<Difficulties> Difficulties { get; set; }

    }
}
