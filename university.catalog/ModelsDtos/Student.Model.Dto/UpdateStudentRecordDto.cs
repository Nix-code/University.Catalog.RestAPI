using System.ComponentModel.DataAnnotations;
namespace University.Catalog.ModelsDtos{

    public record UpdateStudentRecordDto {
        [Required]
        public string? StudentName { get; init; }
        [Required]
        public string? StudentAddress { get; init; }
        [Required]
        // can be changed as per the requirement
        [Range(16,40)]
        public int StudentAge { get; init; }
        [Required]
        public string? StudentEmailAddress { get; init; }
        public DateTimeOffset StudentEnrollmentDate { get; init; }
        [Required]
        public string? CountryName { get; init; }
        [Required]
        public string? StudentGender { get; init; }
        [Required]
        public long StudentContactNumber { get; init; }
        [Required]
        public bool IsScholar { get; init; }
        [Required]
        public string? CoreBranchName { get; init; }
        [Required]
        public string? EmergencyContactName { get; init; }
        [Required]
        public long EmergencyContactNumber { get; init; }

        public string? BloodGroup { get; init; }
        [Required]
        public bool IsDayScholar { get; init; }
        [Required]
        public int DurationForCourse { get; init; }
    }
}