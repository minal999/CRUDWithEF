using CRUD_With_EF.Models;
using Microsoft.EntityFrameworkCore;
namespace CRUD_With_EF.Model

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
