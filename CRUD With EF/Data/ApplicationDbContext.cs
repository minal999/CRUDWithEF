using Microsoft.EntityFrameworkCore;

namespace CRUD_With_EF.Model

{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {

        }
    }
}