using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using University.Catalog.Entities;
using University.Catalog.ModelsDtos;
using University.Catalog.Helper;

namespace University.Catalog.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly DBContext dbContext;

        public StudentController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<StudentEntityDto> GetAllStudents()
        {
            var studentRecords = dbContext.Students.Select(existingRecord => existingRecord.AsDto());
            return studentRecords;
        }

        [HttpGet("{StudentUniqueId}")]
        public ActionResult<StudentEntityDto> GetStudentById(string StudentUniqueId)
        {
            var studentRecord = dbContext.Students.FirstOrDefault(existingRecord => existingRecord.StudentUniqueId == StudentUniqueId);
            return studentRecord is null ? NotFound() : studentRecord.AsDto();
        }

        [HttpPost]
        public ActionResult<StudentEntityDto> CreateStudent(CreateStudentRecordDto studentDto)
        {
            var student = new StudentEntity
            {
                StudentUniqueId = studentDto.StudentUniqueId,
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

            dbContext.Students.Add(student);
            dbContext.SaveChanges();

            var studentDtoResult = student.AsDto();

            return CreatedAtAction(nameof(GetStudentById), new { StudentUniqueId = student.StudentUniqueId }, studentDtoResult);
        }

        [HttpPut("{StudentUniqueId}")]
        public ActionResult<StudentEntityDto> UpdateStudent(string StudentUniqueId, UpdateStudentRecordDto studentDto)
        {
            var existingRecord = dbContext.Students.FirstOrDefault(existingRecord => existingRecord.StudentUniqueId == StudentUniqueId);

            if (existingRecord is null)
            {
                return NotFound();
            }

              var student = new StudentEntity
            {
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

            

            dbContext.SaveChanges();

            return NoContent();
        }

        
    }
}
