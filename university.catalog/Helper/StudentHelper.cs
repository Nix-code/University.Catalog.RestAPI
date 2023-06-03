using University.Catalog.Entities;
using University.Catalog.ModelsDtos;

namespace University.Catalog.Helper {
    public static class StudentHelper {
        public static StudentEntityDto AsDto(this StudentEntity student){

            return new StudentEntityDto {
                StudentUniqueId = student.StudentUniqueId,
                StudentName = student.StudentName,
                StudentAddress = student.StudentAddress,
                StudentAge = student.StudentAge,
                StudentEmailAddress = student.StudentEmailAddress,
                StudentEnrollmentDate = student.StudentEnrollmentDate,
                CountryName = student.CountryName,
                StudentGender = student.StudentGender,
                StudentContactNumber = student.StudentContactNumber,
                IsScholar = student.IsScholar,
                CoreBranchName = student.CoreBranchName,
                EmergencyContactName = student.EmergencyContactName,
                EmergencyContactNumber = student.EmergencyContactNumber,
                BloodGroup = student.BloodGroup,
                IsDayScholar = student.IsDayScholar,
                DurationForCourse = student.DurationForCourse

            };
        }
    }
}
