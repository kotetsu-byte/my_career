﻿using MyCareerServer.User_Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCareerServer.FreelanceModels
{
    public class Resume
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Photo { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? Street { get; set; }
        public string? Position { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Skills { get; set; }
        public string? Hobbies { get; set; }
        public string? AboutSelf { get; set; }
        public int? SelectedTemplate { get; set; }
        public string? Website { get; set; }
        public string? Whatsapp { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Telegram { get; set; }
        public string? Github { get; set; }
        public string? Twitter { get; set; }
        public IEnumerable<Language>? Languages { get; set; }
        public IEnumerable<Experience>? Experinces { get; set; }
        public IEnumerable<Education>? Educations { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
