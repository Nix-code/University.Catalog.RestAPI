using System;

namespace University.Catalog.DataAccess.Entities
{
    public record StudentEntity
    {
        public string? StudentUniqueId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentAddress { get; set; }
        public int StudentAge { get; set; }
        public string? StudentEmailAddress { get; set; }
        public DateTimeOffset StudentEnrollmentDate { get; set; }
        public string? CountryName { get; set; }
        public string? StudentGender { get; set; }
        public long StudentContactNumber { get; set; }
        public bool IsScholar { get; set; }
        public string? CoreBranchName { get; set; }
        public string? EmergencyContactName { get; set; }
        public long EmergencyContactNumber { get; set; }
        public string? BloodGroup { get; set; }
        public bool IsDayScholar { get; set; }
        public int DurationForCourse { get; set; }

    }
}




