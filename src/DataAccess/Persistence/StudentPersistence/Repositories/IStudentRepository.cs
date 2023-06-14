using System.Collections.Generic;
using System.Threading.Tasks;
using University.Catalog.DataAccess.Entities;
using University.Catalog.BusinessLogic.ModelsDtos;

namespace University.Catalog.Persistence.Repositories {

    public interface IStudentRepository {
        
        Task<StudentEntity> GetStudentByIdAsync (string StudentUniqueId);
        Task<List<StudentEntity>> GetAllStudentsAsync();
        Task CreateStudentAsync(StudentEntity student);
        Task UpdateStudentAsync(StudentEntity student);
        Task DeleteStudentAsync(StudentEntity student);
     
    }
}