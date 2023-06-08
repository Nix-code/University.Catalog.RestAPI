using Microsoft.EntityFrameworkCore;
using System;

namespace University.Catalog.Entities
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public virtual DbSet<StudentEntity> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=127.0.0.1;User ID=devadmin;Password=n33x123;Port=3306;Database=universityDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentEntity>(entity =>
            {
                entity.ToTable("studentTable");
                entity.HasKey(e => e.StudentUniqueId);

                 entity.Property(e => e.StudentUniqueId).HasColumnName("StudentUniqueId");
                entity.Property(e => e.StudentName).HasColumnName("StudentName");
                entity.Property(e => e.StudentAddress).HasColumnName("StudentAddress");
                entity.Property(e => e.StudentAge).HasColumnName("StudentAge");
                entity.Property(e => e.StudentEmailAddress).HasColumnName("StudentEmailAddress");
                entity.Property(e => e.StudentEnrollmentDate).HasColumnName("StudentEnrollmentDate");
                entity.Property(e => e.CountryName).HasColumnName("CountryName");
                entity.Property(e => e.StudentGender).HasColumnName("StudentGender");
                entity.Property(e => e.StudentContactNumber).HasColumnName("StudentContactNumber");
                entity.Property(e => e.IsScholar).HasColumnName("IsScholar");
                entity.Property(e => e.CoreBranchName).HasColumnName("CoreBranchName");
                entity.Property(e => e.EmergencyContactName).HasColumnName("EmergencyContactName");
                entity.Property(e => e.EmergencyContactNumber).HasColumnName("EmergencyContactNumber");
                entity.Property(e => e.BloodGroup).HasColumnName("BloodGroup");
                entity.Property(e => e.IsDayScholar).HasColumnName("IsDayScholar");
                entity.Property(e => e.DurationForCourse).HasColumnName("DurationForCourse");

                // Optionally, seed some initial data
                entity.HasData(new StudentEntity
                {
                    StudentUniqueId = "gfgjdkflgjlkd223",
                    StudentName = "John Doe",
                    // Set other properties...
                    StudentAddress = "123 Main St",
                    StudentAge = 20,
                    StudentEmailAddress = "john.doe@example.com",
                    StudentEnrollmentDate = DateTimeOffset.UtcNow,
                    CountryName = "United States",
                    StudentGender = "Male",
                    StudentContactNumber = 1234567890,
                    IsScholar = false,
                    CoreBranchName = "Computer Science",
                    EmergencyContactName = "Jane Doe",
                    EmergencyContactNumber = 9876543210,
                    BloodGroup = "O+",
                    IsDayScholar = true,
                    DurationForCourse = 4
                });
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
