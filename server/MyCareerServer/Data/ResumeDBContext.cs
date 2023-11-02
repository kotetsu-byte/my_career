using Microsoft.EntityFrameworkCore;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Data
{
    public class ResumeDBContext : DbContext
    {
        public ResumeDBContext(DbContextOptions<ResumeDBContext> options) : base(options) { }

        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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

            modelBuilder.Entity<Contact>()
                .HasOne(r => r.Resume)
                .WithMany(c => c.Contacts)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
