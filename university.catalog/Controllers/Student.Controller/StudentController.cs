using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using University.Catalog.Entities;
using University.Catalog.ModelsDtos;
using University.Catalog.Helper;
using University.Catalog.Persistence;
using University.Catalog.Persistence.Repositories;
namespace University.Catalog.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentEntityDto>> GetAllStudents() {
            
            var studentRecord = await studentRepository.GetAllStudentsAsync();
            return studentRecord.Select(existingRecord => existingRecord.AsDto());
        }

        [HttpGet("{StudentUniqueId}")]
        public async Task<ActionResult<StudentEntityDto>> GetStudentById(string StudentUniqueId)
        {
            var studentRecord = await studentRepository.GetStudentByIdAsync(StudentUniqueId);
            return studentRecord is null ? NotFound() : studentRecord.AsDto();
        }

        [HttpPost]
        public async Task<ActionResult<StudentEntityDto>> CreateStudent(CreateStudentRecordDto studentDto)
        {
            var student = studentDto.AsEntity();

            await studentRepository.CreateStudentAsync(student);

            var studentDtoResult = student.AsDto();

            return CreatedAtAction(nameof(GetStudentById), new { StudentUniqueId = student.StudentUniqueId }, studentDtoResult);
        }

        
    }
}
