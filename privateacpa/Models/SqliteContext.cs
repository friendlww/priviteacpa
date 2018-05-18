using Microsoft.EntityFrameworkCore;

namespace privateacpa.Models
{
    public class SqliteContext : DbContext
    {
        public DbSet<DBUser> DBUser { get; set; }
        public DbSet<DBAppInfo> DBAppInfo { get; set; }
        public DbSet<DBAccountInfo> DBAccountInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PwdDataBase.db");
        }
    }

    
}
