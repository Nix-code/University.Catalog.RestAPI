using System.ComponentModel.DataAnnotations;
namespace University.Catalog.BusinessLogic.ModelsDtos{

    public record UpdateStudentRecordDto {
        [Required]
        public string? StudentName { get; set; }
        [Required]
        public string? StudentAddress { get; set; }
        [Required]
        // can be changed as per the requirement
        [Range(16,40)]
        public int StudentAge { get; set; }
        [Required]
        public string? StudentEmailAddress { get; set; }
        public DateTimeOffset StudentEnrollmentDate { get; set; }
        [Required]
        public string? CountryName { get; set; }
        [Required]
        public string? StudentGender { get; set; }
        [Required]
        public long StudentContactNumber { get; set; }
        [Required]
        public bool IsScholar { get; set; }
        [Required]
        public string? CoreBranchName { get; set; }
        [Required]
        public string? EmergencyContactName { get; set; }
        [Required]
        public long EmergencyContactNumber { get; set; }

        public string? BloodGroup { get; set; }
        [Required]
        public bool IsDayScholar { get; set; }
        [Required]
        public int DurationForCourse { get; set; }
    }
}