namespace MyCareerServer.Dtos
{
    public class ExperienceDto
    {
        public int? Id { get; set; }
        public string? CompanyName { get; set; }
        public string? Position { get; set; }
        public string? Begin { get; set; }
        public string? End { get; set; }
        public string? Description { get; set; }
        public bool? IsWorking { get; set; }
        public int? ResumeId { get; set; }
    }
}
