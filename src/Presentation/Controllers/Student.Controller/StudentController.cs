
using Microsoft.AspNetCore.Mvc;
using University.Catalog.BusinessLogic.ModelsDtos;
using University.Catalog.Helper;
using University.Catalog.Persistence.Repositories;
namespace University.Catalog.Presentation.Controllers.Student.Controller
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
        public async Task<ActionResult<IEnumerable<StudentEntityDto>>> GetAllStudents()
        {

            try
            {

                var studentRecord = await studentRepository.GetAllStudentsAsync();
                return Ok(studentRecord.Select(existingRecord => existingRecord.AsDto()));

            }

            catch (Exception ex)
            {
                return Problem(ex.Message, statusCode: 500);

            }
        }

        [HttpGet("{StudentUniqueId}")]
        public async Task<ActionResult<StudentEntityDto>> GetStudentById(string StudentUniqueId)
        {
            try
            {
                var studentRecord = await studentRepository.GetStudentByIdAsync(StudentUniqueId);
                return Ok(studentRecord is null ? NotFound() : studentRecord.AsDto());

            }

            catch (Exception ex)
            {
                return Problem(ex.Message, statusCode: 500);
            }
        }

        [HttpPost]
        public async Task<ActionResult<StudentEntityDto>> CreateStudent(CreateStudentRecordDto studentDto)
        {
            try
            {
                var student = studentDto.AsCreateEntity();

                await studentRepository.CreateStudentAsync(student);

                var studentDtoResult = student.AsDto();

                return CreatedAtAction(nameof(GetStudentById), new { StudentUniqueId = student.StudentUniqueId }, studentDtoResult);

            }

            catch (Exception ex)
            {

                return Problem(ex.Message, statusCode: 500);
            }
        }

        [HttpPut("{StudentUniqueId}")]
        public async Task<ActionResult<StudentEntityDto>> UpdateStudent(string StudentUniqueId, UpdateStudentRecordDto studentDto)
        {
            try
            {
                var existingStudent = await studentRepository.GetStudentByIdAsync(StudentUniqueId);

                if (existingStudent == null)
                {
                    return NotFound($"Student with Id = {StudentUniqueId} not found");
                }

                var updatedStudent = studentDto.AsUpdateEntity(StudentUniqueId);
                await studentRepository.UpdateStudentAsync(updatedStudent);

                var updatedStudentDto = updatedStudent.AsDto();
                return Ok(updatedStudentDto);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, statusCode: 500);
            }
        }

        [HttpDelete("{StudentUniqueId}")]

        public async Task<ActionResult<StudentEntityDto>> DeleteStudent(string studentUniqueId){

            try {

                var existingStudent = await studentRepository.GetStudentByIdAsync(studentUniqueId);

                if(existingStudent == null){
                    return NotFound($"Student with Id = {studentUniqueId} not found");
                }

                await studentRepository.DeleteStudentAsync(existingStudent);

                return Ok($"Student record with StudentUniqueId = {studentUniqueId} deleted successfully");
                

            }

            catch(Exception ex){
                return Problem(ex.Message, statusCode: 500);
            }
        }


    }
}
