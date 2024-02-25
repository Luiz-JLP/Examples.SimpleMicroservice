using Microsoft.EntityFrameworkCore;
using Services.People.Models;

namespace Services.People.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; } = null!;
    }
}
