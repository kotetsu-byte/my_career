namespace MyCareerServer.Dtos
{
    public class EducationDto
    {
        public int? Id { get; set; }
        public string? SchoolName { get; set; }
        public string? Degree { get; set; }
        public string? TypeOfStudy { get; set; }
        public string? Location { get; set; }
        public string? Begin { get; set; }
        public string? End { get; set; }
        public bool? IsCurrently { get; set; }
        public int? ResumeId { get; set; }
    }
}
