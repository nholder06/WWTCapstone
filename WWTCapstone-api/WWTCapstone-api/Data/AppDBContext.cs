using Microsoft.EntityFrameworkCore;
using WWTCapstone_api.Models;

namespace WWTCapstone_api.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext (DbContextOptions<AppDBContext> options) : base (options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
