using Mera_yani_shweta_ka_app.models.User;
using Microsoft.EntityFrameworkCore;

namespace Mera_yani_shweta_ka_app.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
                   : base(options)
        {
        }

        // Example: Your table
        public DbSet<Customer> CustomerDetails { get; set; }

    }
}
