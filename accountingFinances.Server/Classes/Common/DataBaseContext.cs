using accountingFinances.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace accountingFinances.Server.Classes.Common
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Operation> Operations { get; set; }
    }
}
