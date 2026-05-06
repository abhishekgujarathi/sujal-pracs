using System.Data.Entity.ModelConfiguration;

namespace Practical_13_2.Models
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("Employee");
            HasKey(e => e.Id);

            Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(e => e.MiddleName)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(e => e.DOB)
                .IsRequired()
                .HasColumnType("date");

            Property(e => e.MobileNumber)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");

            Property(e => e.Address)
                .IsOptional()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(e => e.Salary)
                .IsRequired()
                .HasPrecision(18, 2);

            HasOptional(e => e.Designation)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DesignationId)
                .WillCascadeOnDelete(false);
        }
    }
}