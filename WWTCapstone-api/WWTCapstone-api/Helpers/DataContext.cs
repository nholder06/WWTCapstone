using Microsoft.EntityFrameworkCore;
using WWTCapstone_api.Models;

namespace WWTCapstone_api.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) { }

        public DbSet<User> User { get; set; }

        public DbSet<Pet> Pet { get; set; }
    }
}
