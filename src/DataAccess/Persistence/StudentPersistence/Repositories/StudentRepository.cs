using Microsoft.EntityFrameworkCore;
using University.Catalog.DataAccess.Entities;
namespace University.Catalog.Persistence.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        private readonly DBContext _dbContext;
        public StudentRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<StudentEntity> GetStudentByIdAsync(string StudentUniqueId)
        {
            return await _dbContext.Students.FindAsync(StudentUniqueId);
        }

        public async Task<List<StudentEntity>> GetAllStudentsAsync()
        {

            return await _dbContext.Students.ToListAsync();
        }

        public async Task CreateStudentAsync(StudentEntity student)
        {

            await _dbContext.Students.AddRangeAsync(student);
            await _dbContext.SaveChangesAsync();
        }

        

        public async Task UpdateStudentAsync(StudentEntity student)
        {
            try
            {
                
                // var existingStudent = await _dbContext.Students.FindAsync(student.StudentUniqueId);
                var existingStudent = await _dbContext.Students
                .FirstOrDefaultAsync(e => e.StudentUniqueId == student.StudentUniqueId);
                if (existingStudent == null)
                {
                    throw new Exception("Student not found");
                }

                // Update the existing student with the new values
                existingStudent.StudentName = student.StudentName;
                existingStudent.StudentAddress = student.StudentAddress;
                existingStudent.StudentAge = student.StudentAge;
                existingStudent.StudentEmailAddress = student.StudentEmailAddress;
                existingStudent.StudentEnrollmentDate = student.StudentEnrollmentDate;
                existingStudent.CountryName = student.CountryName;
                existingStudent.StudentGender = student.StudentGender;
                existingStudent.StudentContactNumber = student.StudentContactNumber;
                existingStudent.IsScholar = student.IsScholar;
                existingStudent.CoreBranchName = student.CoreBranchName;
                existingStudent.EmergencyContactName = student.EmergencyContactName;
                existingStudent.EmergencyContactNumber = student.EmergencyContactNumber;
                existingStudent.BloodGroup = student.BloodGroup;
                existingStudent.IsDayScholar = student.IsDayScholar;
                existingStudent.DurationForCourse = student.DurationForCourse;

                // Save the changes to the database
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the update process
                throw new Exception("Failed to update student", ex);
            }
        }


    }
}