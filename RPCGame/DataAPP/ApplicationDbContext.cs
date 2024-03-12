using Microsoft.EntityFrameworkCore;
using RPCGame.Models;

namespace RPCGame.DataAPP
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<GameTransaction> gameTransactions { get; set; }
        public DbSet<Match> matches { get; set; }
        public DbSet<MatchHistorycs> matchesHistory { get; set; }
        public DbSet<User> users { get; set; }  
    }
}
    