using System.Data.Entity;

namespace Practical_13_2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Default") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Designation> Designations { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new EmployeeConfiguration());
            builder.Configurations.Add(new DesignationConfiguration());
        }
    }
}