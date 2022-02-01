using Microsoft.EntityFrameworkCore;

namespace CarEngines
{
    public class EngineContext : DbContext
    {
        public EngineContext(DbContextOptions<EngineContext> options) : base(options)
        {
        }

        public DbSet<Engine> Engines { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}