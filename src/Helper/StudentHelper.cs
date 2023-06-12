using University.Catalog.DataAccess.Entities;
using University.Catalog.BusinessLogic.ModelsDtos;

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

        public static StudentEntity AsEntity (this CreateStudentRecordDto studentDto){

            return new StudentEntity {
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
        }
    }
}
