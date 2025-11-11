using Microsoft.EntityFrameworkCore;
using WpfApp26.Models;

namespace WpfApp26.Classes
{
    public class ClubsContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public ClubsContext() =>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.ConnectionConfig);
        }
    }
}
