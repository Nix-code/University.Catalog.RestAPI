using Xunit;
using University.Catalog.BusinessLogic.ModelsDtos;

namespace University.Catalog.BusinessLogic.ModelsDtos.Tests
{

    public class CreateStudentRecordDtoTests
    {

        [Fact]
        public void StudentRecordCreationDto_InitializedCorrectly()
        {

            // Arrange 
            var studentUniqueId = "12345";
            var studentName = "John Doe";
            var studentAddress = "123 Main Street";
            var studentAge = 20;
            var studentEmailAddress = "john.doe@example.com";
            var studentEnrollmentDate = new DateTimeOffset(2023, 1, 1, 0, 0, 0, TimeSpan.Zero);
            var countryName = "USA";
            var studentGender = "Male";
            var studentContactNumber = 1234567890;
            var isScholar = true;
            var coreBranchName = "Computer Science";
            var emergencyContactName = "Jane Doe";
            var emergencyContactNumber = 9876543210;
            var bloodGroup = "A+";
            var isDayScholar = false;
            var durationForCourse = 4;

            // Act

            var CreateStudentRecordDto = new CreateStudentRecordDto
            {
                StudentUniqueId = studentUniqueId,
                StudentName = studentName,
                StudentAddress = studentAddress,
                StudentAge = studentAge,
                StudentEmailAddress = studentEmailAddress,
                StudentEnrollmentDate = studentEnrollmentDate,
                CountryName = countryName,
                StudentGender = studentGender,
                StudentContactNumber = studentContactNumber,
                IsScholar = isScholar,
                CoreBranchName = coreBranchName,
                EmergencyContactName = emergencyContactName,
                EmergencyContactNumber = emergencyContactNumber,
                BloodGroup = bloodGroup,
                IsDayScholar = isDayScholar,
                DurationForCourse = durationForCourse
            };

            // Assert
            Assert.Equal(studentUniqueId, CreateStudentRecordDto.StudentUniqueId);
            Assert.Equal(studentName, CreateStudentRecordDto.StudentName);
            Assert.Equal(studentAddress, CreateStudentRecordDto.StudentAddress);
            Assert.Equal(studentAge, CreateStudentRecordDto.StudentAge);
            Assert.Equal(studentEmailAddress, CreateStudentRecordDto.StudentEmailAddress);
            Assert.Equal(studentEnrollmentDate, CreateStudentRecordDto.StudentEnrollmentDate);
            Assert.Equal(countryName, CreateStudentRecordDto.CountryName);
            Assert.Equal(studentGender, CreateStudentRecordDto.StudentGender);
            Assert.Equal(studentContactNumber, CreateStudentRecordDto.StudentContactNumber);
            Assert.Equal(isScholar, CreateStudentRecordDto.IsScholar);
            Assert.Equal(coreBranchName, CreateStudentRecordDto.CoreBranchName);
            Assert.Equal(emergencyContactName, CreateStudentRecordDto.EmergencyContactName);
            Assert.Equal(emergencyContactNumber, CreateStudentRecordDto.EmergencyContactNumber);
            Assert.Equal(bloodGroup, CreateStudentRecordDto.BloodGroup);
            Assert.Equal(isDayScholar, CreateStudentRecordDto.IsDayScholar);
            Assert.Equal(durationForCourse, CreateStudentRecordDto.DurationForCourse);

        }
    }
}