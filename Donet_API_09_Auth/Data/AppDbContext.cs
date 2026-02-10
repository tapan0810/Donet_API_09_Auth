using Donet_API_09_Auth.Entities;
using Microsoft.EntityFrameworkCore;

namespace Donet_API_09_Auth.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
    }
}
