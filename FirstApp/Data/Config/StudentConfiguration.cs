using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FirstApp.Data; // Yeh zaroori hai Student class ke liye

namespace FirstApp.Data.Config
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Table Name
            builder.ToTable("Students");

            // Primary Key
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            // Properties Config
            builder.Property(n => n.StudentName).IsRequired().HasMaxLength(250);
            builder.Property(n => n.Address).IsRequired(false).HasMaxLength(500);
            builder.Property(n => n.Email).IsRequired().HasMaxLength(250);

            // Seed Data (Fake Data)
            builder.HasData(new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    StudentName = "TALHA",
                    Email = "talhahakeem.tech@gmail.com",
                    Address = "Lahore",
                    DOB = new DateTime(2006, 01, 31)
                },
                new Student()
                {
                    Id = 2,
                    StudentName = "AHMAD",
                    Email = "ahmad@gmail.com",
                    Address = "Lahore",
                    DOB = new DateTime(2008, 05, 20)
                }
            });
        }
    }
}