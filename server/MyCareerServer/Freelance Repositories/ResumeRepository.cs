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

        public async Task<IEnumerable<Resume>> GetResumes(int userId)
        {
            return await _dbContext.Resumes.Where(r => r.User.Id == userId).ToListAsync();
        }

        public async Task<Resume> GetResumeById(int id)
        {
            return await _dbContext.Resumes.Where(r => r.Id == id).FirstOrDefaultAsync();
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

        public bool Delete(int id)
        {
            var resume = _dbContext.Resumes.Where(r => r.Id == id).FirstOrDefault();
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
