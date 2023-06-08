using Microsoft.EntityFrameworkCore;

namespace University.Catalog.Entities {

    public partial class DBContext: DbContext {

        public DBContext() {

        }

        public DBContext(DbContextOptions<DBContext> options) : base(options){

        }
        
        
        public virtual DbSet<StudentEntity> students {get; set;}

        // Creating 'OnModelCreating' method to define the mapping between 
        // 'StudentEntity' class and the 'studentTable' in the database.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentEntity> (entity => {
                entity.ToTable("studentTable"); // specify the table name
                entity.HasKey(e => e.StudentUniqueId); // primary key

                // define the column mappings

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
                
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}