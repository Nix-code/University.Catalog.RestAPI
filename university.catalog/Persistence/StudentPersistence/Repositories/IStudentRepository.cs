using System.Collections.Generic;
using System.Threading.Tasks;
using University.Catalog.Entities;

namespace University.Catalog.Persistence.Repositories {

    public interface IStudentRepository {
        
        Task<StudentEntity> GetStudentByIdAsync (string StudentUniqueId);
        Task<List<StudentEntity>> GetAllStudentsAsync();
        Task CreateStudentAsync(StudentEntity student);
     
    }
}