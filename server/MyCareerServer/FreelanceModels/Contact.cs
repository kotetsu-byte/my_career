using System.ComponentModel.DataAnnotations.Schema;

namespace MyCareerServer.FreelanceModels
{
    public class Contact
    {
        public string? Media { get; set; }
        public string? Address { get; set; }
        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
