using DbPerfTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DbPerfTest.Contexts
{
    public class PostgresPerfTestContext : DbContext
    {
        public PostgresPerfTestContext()
        {
        }

        public PostgresPerfTestContext(DbContextOptions<PostgresPerfTestContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}