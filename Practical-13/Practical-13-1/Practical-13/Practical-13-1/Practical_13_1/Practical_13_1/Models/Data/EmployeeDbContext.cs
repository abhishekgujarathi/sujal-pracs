using System.Data.Entity;

namespace Practical_13_1.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("Default") { }

        public DbSet<Employee> Employees { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new EmployeeConfig());
        }
    }
}