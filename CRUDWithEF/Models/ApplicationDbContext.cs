
using Microsoft.EntityFrameworkCore;

namespace CRUDWithEF.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    }
}