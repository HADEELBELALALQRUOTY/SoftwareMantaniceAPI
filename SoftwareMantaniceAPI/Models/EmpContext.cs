using Microsoft.EntityFrameworkCore;

namespace SoftwareMantaniceAPI.Models
{
    public class EmpContext: DbContext
    {
        //relashionshipe with database 
        public EmpContext (DbContextOptions Options) : base(Options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }


    }
}
