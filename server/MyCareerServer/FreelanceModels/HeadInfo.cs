
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCareerServer.FreelanceModels
{
    public class HeadInfo
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email {  get; set; }
        public string? PhoneNumber { get; set; }
        public FileStream? Image { get; set; }
        public Address? Address { get; set; }
        public string[]? Skills { get; set; }
        public string[]? Hobbies { get; set; }
        public string? AboutSelf { get; set; }
        [ForeignKey("Resume")]
        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
