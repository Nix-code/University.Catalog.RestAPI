using Xunit;
using University.Catalog.BusinessLogic.ModelsDtos;

namespace University.Catalog.BusinessLogic.ModelsDtos.Tests
{

    public class UpdateStudentRecordDtoTests
    {

        [Fact]
        public void UpdateStudentRecordCreationDto_InitializedCorrectly()
        {

            // Arrange 
           
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

            var UpdateStudentRecordDto = new UpdateStudentRecordDto
            {
               
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
            
            Assert.Equal(studentName, UpdateStudentRecordDto.StudentName);
            Assert.Equal(studentAddress, UpdateStudentRecordDto.StudentAddress);
            Assert.Equal(studentAge, UpdateStudentRecordDto.StudentAge);
            Assert.Equal(studentEmailAddress, UpdateStudentRecordDto.StudentEmailAddress);
            Assert.Equal(studentEnrollmentDate, UpdateStudentRecordDto.StudentEnrollmentDate);
            Assert.Equal(countryName, UpdateStudentRecordDto.CountryName);
            Assert.Equal(studentGender, UpdateStudentRecordDto.StudentGender);
            Assert.Equal(studentContactNumber, UpdateStudentRecordDto.StudentContactNumber);
            Assert.Equal(isScholar, UpdateStudentRecordDto.IsScholar);
            Assert.Equal(coreBranchName, UpdateStudentRecordDto.CoreBranchName);
            Assert.Equal(emergencyContactName, UpdateStudentRecordDto.EmergencyContactName);
            Assert.Equal(emergencyContactNumber, UpdateStudentRecordDto.EmergencyContactNumber);
            Assert.Equal(bloodGroup, UpdateStudentRecordDto.BloodGroup);
            Assert.Equal(isDayScholar, UpdateStudentRecordDto.IsDayScholar);
            Assert.Equal(durationForCourse, UpdateStudentRecordDto.DurationForCourse);


        }
    }
}