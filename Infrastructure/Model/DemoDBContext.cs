using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Model
{
    public class DemoDBContext : DbContext
    {
        public DemoDBContext(DbContextOptions<DemoDBContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Role> Role { get; set; }

    }

}
