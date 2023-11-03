using System.ComponentModel.DataAnnotations.Schema;

namespace MyCareerServer.FreelanceModels
{
    public class Experience
    {
        public int? Id { get; set; }
        public string? CompanyName { get; set; }
        public string? Position { get; set; }
        public string? Begin { get; set; }
        public string? End { get; set; }
        public string? Description { get; set; }
        public bool? IsWorking { get; set; }
        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
