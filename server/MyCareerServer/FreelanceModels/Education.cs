using System.ComponentModel.DataAnnotations.Schema;

namespace MyCareerServer.FreelanceModels
{
    public class Education
    {
        public string? InstituteName { get; set; }
        public string? Degree { get; set; }
        public string? Major { get; set; }
        public string? Begin {  get; set; }
        public string? End { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
