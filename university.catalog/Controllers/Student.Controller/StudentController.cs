using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using University.Catalog.Entities;
using University.Catalog.Repositories;
using University.Catalog.ModelsDtos;
using University.Catalog.Helper;
namespace University.Catalog.Controllers {

    [ApiController]
    [Route("students")]
    public class StudentController : ControllerBase {

        private readonly IStudentRepository studentRepository;
        public StudentController (IStudentRepository studentRepository) {
            this.studentRepository = studentRepository;
        }
        [HttpGet]
        public IEnumerable<StudentEntityDto> GetAllStudents() {
            var studentRecord = studentRepository.GetAllStudents().Select(existingRecord => existingRecord.AsDto());
            return studentRecord;
        }

        // GET / students/{id}
        [HttpGet("{StudentUniqueId}")]
        public ActionResult<StudentEntityDto> GetStudentById(Guid StudentUniqueId){
            var studentRecord = studentRepository.GetStudentById(StudentUniqueId);
            return studentRecord is null ? NotFound() : studentRecord.AsDto();
        }
        // POST/students
        [HttpPost]
        public ActionResult<StudentEntity> CreateStudent(CreateStudentRecordDto studentDto){
            StudentEntity student = new () {
                StudentUniqueId = Guid.NewGuid(),
                StudentName = studentDto.StudentName,
                StudentAddress = studentDto.StudentAddress,
                StudentAge = studentDto.StudentAge,
                StudentEmailAddress = studentDto.StudentEmailAddress,
                StudentEnrollmentDate = studentDto.StudentEnrollmentDate,
                CountryName = studentDto.CountryName,
                StudentGender = studentDto.StudentGender,
                StudentContactNumber = studentDto.StudentContactNumber,
                IsScholar = studentDto.IsScholar,
                CoreBranchName = studentDto.CoreBranchName,
                EmergencyContactName = studentDto.EmergencyContactName,
                EmergencyContactNumber = studentDto.EmergencyContactNumber,
                BloodGroup = studentDto.BloodGroup,
                IsDayScholar = studentDto.IsDayScholar,
                DurationForCourse = studentDto.DurationForCourse


            };
            return CreatedAtAction(nameof(GetStudentById), new {studentUniqueId = student.StudentUniqueId}, student.AsDto());

        }

        // PUT /students/{uniqueId}
        [HttpPut("{StudentUniqueId}")]
        public ActionResult<StudentEntity> UpdateStudent(Guid StudentUniqueId, UpdateStudentRecordDto studentDto){

            var existingRecord = studentRepository.GetStudentById(StudentUniqueId);
            if (existingRecord is null){
                return NotFound();
            }
            StudentEntity updatedstudent = existingRecord with{
                StudentUniqueId = Guid.NewGuid(),
                StudentName = studentDto.StudentName,
                StudentAddress = studentDto.StudentAddress,
                StudentAge = studentDto.StudentAge,
                StudentEmailAddress = studentDto.StudentEmailAddress,
                StudentEnrollmentDate = studentDto.StudentEnrollmentDate,
                CountryName = studentDto.CountryName,
                StudentGender = studentDto.StudentGender,
                StudentContactNumber = studentDto.StudentContactNumber,
                IsScholar = studentDto.IsScholar,
                CoreBranchName = studentDto.CoreBranchName,
                EmergencyContactName = studentDto.EmergencyContactName,
                EmergencyContactNumber = studentDto.EmergencyContactNumber,
                BloodGroup = studentDto.BloodGroup,
                IsDayScholar = studentDto.IsDayScholar,
                DurationForCourse = studentDto.DurationForCourse


            };
            studentRepository.UpdateStudent(updatedstudent);
            return NoContent();

    }
}
}