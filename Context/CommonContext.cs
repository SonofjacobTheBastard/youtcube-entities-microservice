
using Microsoft.EntityFrameworkCore;

namespace YoutCubeEntitiesMicroservice.Context
{
    public class CommonContext : DbContext
    {
        public CommonContext(DbContextOptions<CommonContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ConnectionString");
            }
        }
    }
}