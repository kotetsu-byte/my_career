using System.ComponentModel.DataAnnotations.Schema;

namespace MyCareerServer.FreelanceModels
{
    public class Education
    {
        public int? Id { get; set; }
        public string? SchoolName { get; set; }
        public string? Degree { get; set; }
        public string? TypeOfStudy { get; set; }
        public string? Location { get; set; }
        public string? Begin {  get; set; }
        public string? End { get; set; }
        public bool? IsCurrently { get; set; }
        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
