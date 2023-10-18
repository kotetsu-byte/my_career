using Microsoft.EntityFrameworkCore;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Data
{
    public class ResumeDBContext : DbContext
    {
        public ResumeDBContext(DbContextOptions<ResumeDBContext> options) : base(options) { }

        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<HeadInfo> HeadInfos { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}
