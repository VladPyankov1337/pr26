using Microsoft.EntityFrameworkCore;
using WpfApp26.Models;

namespace WpfApp26.Classes
{
    public class UserContext: DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UserContext() =>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.ConnectionConfig);
        }
    }
}
