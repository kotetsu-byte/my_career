using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCareerServer.CompanyModels;
using MyCareerServer.FreelanceModels;
using MyCareerServer.User_Model;

namespace MyCareerServer.Data
{
    public class ResumeDBContext : DbContext
    {
        public ResumeDBContext(DbContextOptions<ResumeDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<CompanyResume> CompanyResumes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Resume>()
                .HasOne(u => u.User)
                .WithMany(r => r.Resumes)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Language>()
                .HasOne(r => r.Resume)
                .WithMany(l => l.Languages)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Experience>()
                .HasOne(r => r.Resume)
                .WithMany(e => e.Experinces)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Education>()
                .HasOne(r => r.Resume)
                .WithMany(e => e.Educations)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CompanyResume>()
                .HasOne(u => u.User)
                .WithMany(c => c.CompanyResumes)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
