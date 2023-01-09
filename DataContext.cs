using CanetaApp;
using Microsoft.EntityFrameworkCore;

namespace ConsoleDataBase
{
    public class DataContext : DbContext
    {
        private const string ConnectionString = "Data Source=Caneta.db";
        private static DataContext _databaseContext = null;

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(ConnectionString);
        
        public DbSet<Caneta> Canetas { get; set; }
    }

}