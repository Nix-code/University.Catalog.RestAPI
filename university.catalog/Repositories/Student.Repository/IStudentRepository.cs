using System;
using System.Collections.Generic;
using University.Catalog.Entities;

namespace University.Catalog.Repositories
{
    public interface IStudentRepository
    {
        StudentEntity GetStudentById(Guid studentUniqueId);
        IEnumerable<StudentEntity> GetAllStudents();

        void CreateStudent(StudentEntity student);
        void UpdateStudent(StudentEntity student);

        void DeleteStudent(StudentEntity student);
    }
}
