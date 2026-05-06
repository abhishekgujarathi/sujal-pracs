using System.Data.Entity.ModelConfiguration;

namespace Practical_13_2.Models
{
    public class DesignationConfiguration : EntityTypeConfiguration<Designation>
    {
        public DesignationConfiguration()
        {
            ToTable("Designation");

            HasKey(d => d.Id);

            Property(d => d.DesignationName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Designation")
                .HasColumnType("varchar");
        }
    }
}   