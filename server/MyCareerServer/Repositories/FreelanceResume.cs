using Microsoft.EntityFrameworkCore;
using MyCareerServer.Data;
using MyCareerServer.FreelanceModels;
using MyCareerServer.Interfaces;

namespace MyCareerServer.Repositories
{
    public class FreelanceResume : IFreelanceRepository
    {
        private readonly ResumeDBContext _context;
        public FreelanceResume(ResumeDBContext context)
        {
            _context = context;
        }

        public bool Create(Resume resume)
        {
            _context.Resumes.Add(resume);

            return Save();
        }

        public bool Delete(Resume resume)
        {
            _context.Resumes.Remove(resume);

            return Save();
        }

        public async Task<Resume> GetResumeByEmail(string email)
        {
            return await _context.Resumes.Where(r => r.HeadInfo.Email == email).FirstOrDefaultAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool Update(Resume resume)
        {
            _context.Resumes.Update(resume);

            return Save();
        }
    }
}
