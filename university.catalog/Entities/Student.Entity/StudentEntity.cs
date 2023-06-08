using System;

namespace University.Catalog.Entities
{
    public record StudentEntity
    {
        public string? StudentUniqueId { get; init; }
        public string? StudentName { get; init; }
        public string? StudentAddress { get; init; }
        public int StudentAge { get; init; }
        public string? StudentEmailAddress { get; init; }
        public DateTimeOffset StudentEnrollmentDate { get; init; }
        public string? CountryName { get; init; }
        public string? StudentGender { get; init; }
        public long StudentContactNumber { get; init; }
        public bool IsScholar { get; init; }
        public string? CoreBranchName { get; init; }
        public string? EmergencyContactName { get; init; }
        public long EmergencyContactNumber { get; init; }
        public string? BloodGroup { get; init; }
        public bool IsDayScholar { get; init; }
        public int DurationForCourse { get; init; }
    }
}
