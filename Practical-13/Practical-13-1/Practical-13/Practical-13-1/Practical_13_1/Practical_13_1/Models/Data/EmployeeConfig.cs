using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Practical_13_1.Models
{
    public class EmployeeConfig : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfig()
        {
            ToTable("Employee");

            HasKey(e => e.Id);

            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar");

            Property(e => e.DOB).IsRequired().HasColumnType("date");

            Property(e => e.Age).IsOptional();
        }
    }
}