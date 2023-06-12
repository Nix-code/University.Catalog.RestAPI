using Microsoft.EntityFrameworkCore;
using University.Catalog.DataAccess.Entities;
namespace University.Catalog.Persistence.Repositories {
    public class StudentRepository: IStudentRepository {

        private readonly DBContext _dbContext;
        public StudentRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<StudentEntity> GetStudentByIdAsync (string StudentUniqueId){
            return await _dbContext.Students.FindAsync(StudentUniqueId);
        }

        public async Task<List<StudentEntity>> GetAllStudentsAsync () {

            return await _dbContext.Students.ToListAsync();
        }

        public async Task CreateStudentAsync(StudentEntity student){

            await _dbContext.Students.AddRangeAsync(student);
            await _dbContext.SaveChangesAsync();
        }

    }
}