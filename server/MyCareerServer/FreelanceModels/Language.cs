
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCareerServer.FreelanceModels
{
    public class Language
    {
        public string? Lang { get; set; }
        public string? Level { get; set; }
        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
