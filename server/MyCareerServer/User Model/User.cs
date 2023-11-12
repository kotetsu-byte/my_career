using Microsoft.AspNetCore.Identity;
using MyCareerServer.CompanyModels;
using MyCareerServer.FreelanceModels;
using System.ComponentModel.DataAnnotations;

namespace MyCareerServer.User_Model
{
    public class User
    {
        public int? Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public IEnumerable<Resume>? Resumes { get; set; }
        public IEnumerable<CompanyResume>? CompanyResumes { get; set; }
    }
}
