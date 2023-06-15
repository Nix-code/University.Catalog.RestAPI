using Xunit;
using University.Catalog.BusinessLogic.ModelsDtos;
namespace University.Catalog.BusinessLogic.ModelsDtos.Tests
{

    public class StudentEntityDtoTests
    {

        [Fact]

        public void Properties_InitializedCorrectly()
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
            var StudentEntityDto = new StudentEntityDto
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

            Assert.Equal(studentUniqueId, StudentEntityDto.StudentUniqueId);
            Assert.Equal(studentName, StudentEntityDto.StudentName);
            Assert.Equal(studentAddress, StudentEntityDto.StudentAddress);
            Assert.Equal(studentAge, StudentEntityDto.StudentAge);
            Assert.Equal(studentEmailAddress, StudentEntityDto.StudentEmailAddress);
            Assert.Equal(studentEnrollmentDate, StudentEntityDto.StudentEnrollmentDate);
            Assert.Equal(countryName, StudentEntityDto.CountryName);
            Assert.Equal(studentGender, StudentEntityDto.StudentGender);
            Assert.Equal(studentContactNumber, StudentEntityDto.StudentContactNumber);
            Assert.Equal(isScholar, StudentEntityDto.IsScholar);
            Assert.Equal(coreBranchName, StudentEntityDto.CoreBranchName);
            Assert.Equal(emergencyContactName, StudentEntityDto.EmergencyContactName);
            Assert.Equal(emergencyContactNumber, StudentEntityDto.EmergencyContactNumber);
            Assert.Equal(bloodGroup, StudentEntityDto.BloodGroup);
            Assert.Equal(isDayScholar, StudentEntityDto.IsDayScholar);
            Assert.Equal(durationForCourse, StudentEntityDto.DurationForCourse);



        }
    }
}