using Microsoft.AspNetCore.Identity;
using MyCareerServer.CompanyModels;
using MyCareerServer.FreelanceModels;
using System.ComponentModel.DataAnnotations;

namespace MyCareerServer.User_Model
{
    public class User : IdentityUser
    {
        [Required]
        public override string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public IEnumerable<Resume>? Resumes { get; set; }
        public IEnumerable<CompanyResume>? CompanyResumes { get; set; }
    }
}
