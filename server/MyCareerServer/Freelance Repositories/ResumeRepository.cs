using Microsoft.EntityFrameworkCore;
using MyCareerServer.Data;
using MyCareerServer.Freelance_Interfaces;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Repositories
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly ResumeDBContext _dbContext;

        public ResumeRepository(ResumeDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<IEnumerable<Resume>> GetResumesByEmailAsync(string email)
        {
            return await _dbContext.Resumes.Where(r => r.Email == email).ToListAsync();
        }

        public bool Create(Resume resume)
        {
            _dbContext.Resumes.Add(resume);

            return Save();
        }

        public bool Update(Resume resume)
        {
            _dbContext.Resumes.Update(resume);

            return Save();
        }

        public bool Delete(Resume resume)
        {
            _dbContext.Resumes.Remove(resume);

            return Save();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();

            return saved > 0 ? true : false;
        }
    }
}
