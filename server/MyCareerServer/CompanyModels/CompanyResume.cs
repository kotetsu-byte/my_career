using MyCareerServer.User_Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCareerServer.CompanyModels
{
    public class CompanyResume
    {
        public int? Id { get; set; }
        public string? Photo { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyPhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Website { get; set; }
        public string? Whatsapp { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Telegram { get; set; }
        public string? Github { get; set; }
        public string? Twitter { get; set; }
        public int? TemplateNo { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
