using Xunit;
using University.Catalog.DataAccess.Entities;

namespace University.Catalog.Tests.DataAccess.Entities
{
    public class StudentEntityTests
    {
        [Fact]
        public void StudentEntity_WithValidProperties_ShouldCreateInstance()
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
            var studentEntity = new StudentEntity
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
            Assert.Equal(studentUniqueId, studentEntity.StudentUniqueId);
            Assert.Equal(studentName, studentEntity.StudentName);
            Assert.Equal(studentAddress, studentEntity.StudentAddress);
            Assert.Equal(studentAge, studentEntity.StudentAge);
            Assert.Equal(studentEmailAddress, studentEntity.StudentEmailAddress);
            Assert.Equal(studentEnrollmentDate, studentEntity.StudentEnrollmentDate);
            Assert.Equal(countryName, studentEntity.CountryName);
            Assert.Equal(studentGender, studentEntity.StudentGender);
            Assert.Equal(studentContactNumber, studentEntity.StudentContactNumber);
            Assert.Equal(isScholar, studentEntity.IsScholar);
            Assert.Equal(coreBranchName, studentEntity.CoreBranchName);
            Assert.Equal(emergencyContactName, studentEntity.EmergencyContactName);
            Assert.Equal(emergencyContactNumber, studentEntity.EmergencyContactNumber);
            Assert.Equal(bloodGroup, studentEntity.BloodGroup);
            Assert.Equal(isDayScholar, studentEntity.IsDayScholar);
            Assert.Equal(durationForCourse, studentEntity.DurationForCourse);
        }
    }
}
