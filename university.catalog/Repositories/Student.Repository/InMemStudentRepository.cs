using System;
using System.Linq;
using System.Collections.Generic;
using University.Catalog.Entities;

namespace University.Catalog.Repositories {

    public class InMemStudentRepository : IStudentRepository{

        private readonly List<StudentEntity> students = new () {
            // dummy dataset for initial build , might useful for mocking purpose while performing unit test
            new StudentEntity
            {
                StudentUniqueId = Guid.NewGuid(),
                StudentName = "John Doe",
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
            },
            new StudentEntity
            {
                StudentUniqueId = Guid.NewGuid(),
                StudentName = "Jane Smith",
                StudentAddress = "456 Elm St",
                StudentAge = 22,
                StudentEmailAddress = "jane.smith@example.com",
                StudentEnrollmentDate = DateTimeOffset.UtcNow,
                CountryName = "Canada",
                StudentGender = "Female",
                StudentContactNumber = 5555555555,
                IsScholar = true,
                CoreBranchName = "Mechanical Engineering",
                EmergencyContactName = "John Smith",
                EmergencyContactNumber = 9999999999,
                BloodGroup = "A-",
                IsDayScholar = false,
                DurationForCourse = 3
            },
            new StudentEntity
            {
                StudentUniqueId = Guid.NewGuid(),
                StudentName = "William Johnson",
                StudentAddress = "987 Maple St",
                StudentAge = 21,
                StudentEmailAddress = "william.johnson@example.com",
                StudentEnrollmentDate = DateTimeOffset.UtcNow,
                CountryName = "United States",
                StudentGender = "Male",
                StudentContactNumber = 5555555555,
                IsScholar = true,
                CoreBranchName = "Computer Engineering",
                EmergencyContactName = "Olivia Johnson",
                EmergencyContactNumber = 6666666666,
                BloodGroup = "O+",
                IsDayScholar = false,
                DurationForCourse = 4
            },
            new StudentEntity
            {
                StudentUniqueId = Guid.NewGuid(),
                StudentName = "Sophia Davis",
                StudentAddress = "654 Cedar Ln",
                StudentAge = 20,
                StudentEmailAddress = "sophia.davis@example.com",
                StudentEnrollmentDate = DateTimeOffset.UtcNow,
                CountryName = "Canada",
                StudentGender = "Female",
                StudentContactNumber = 7777777777,
                IsScholar = true,
                CoreBranchName = "Civil Engineering",
                EmergencyContactName = "Daniel Davis",
                EmergencyContactNumber = 8888888888,
                BloodGroup = "B-",
                IsDayScholar = false,
                DurationForCourse = 3
            },
            new StudentEntity
            {
                StudentUniqueId = Guid.NewGuid(),
                StudentName = "Liam Wilson",
                StudentAddress = "852 Willow Ave",
                StudentAge = 19,
                StudentEmailAddress = "liam.wilson@example.com",
                StudentEnrollmentDate = DateTimeOffset.UtcNow,
                CountryName = "United States",
                StudentGender = "Male",
                StudentContactNumber = 9999999999,
                IsScholar = false,
                CoreBranchName = "Mechanical Engineering",
                EmergencyContactName = "Ava Wilson",
                EmergencyContactNumber = 1010101010,
                BloodGroup = "A+",
                IsDayScholar = true,
                DurationForCourse = 4
            }
        };

        public IEnumerable<StudentEntity> GetAllStudents() {
            return students;
        }

        public StudentEntity GetStudentById(Guid studentId){

            // return student id if found, else return null
            // LINQ query
            return students.Where(students => students.StudentUniqueId == studentId).SingleOrDefault();

        }

        public void CreateStudent(StudentEntity student){
            students.Add(student);
        }

        public void UpdateStudent(StudentEntity student){
            var StudentIndex = students.FindIndex(existingStudent => existingStudent.StudentUniqueId == student.StudentUniqueId);
            students[StudentIndex] = student;
        }

        public void DeleteStudent(Guid studentId){
            var StudentIndex = students.FindIndex(existingStudent => existingStudent.StudentUniqueId == studentId);
            students.RemoveAt(StudentIndex);
        }

    }
}
