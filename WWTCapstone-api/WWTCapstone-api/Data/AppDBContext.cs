using Microsoft.EntityFrameworkCore;
using WWTCapstone_api.Helpers;
using WWTCapstone_api.Models;

namespace WWTCapstone_api.Data
{
    public class AppDBContext : DataContext
    {
        public AppDBContext (DbContextOptions<AppDBContext> options) :base(options) {}
        public DbSet<User> authUsers { get; set; }
    }
}
