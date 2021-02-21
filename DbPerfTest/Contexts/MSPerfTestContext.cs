using DbPerfTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DbPerfTest.Contexts
{
    public class MSPerfTestContext : DbContext
    {
        public MSPerfTestContext()
        {
        }

        public MSPerfTestContext(DbContextOptions<MSPerfTestContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}