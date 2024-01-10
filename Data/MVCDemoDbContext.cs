using Microsoft.EntityFrameworkCore;
using WebApplicationEmployeeCRUD.Models.Domain;

namespace WebApplicationEmployeeCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }  

    }
}
