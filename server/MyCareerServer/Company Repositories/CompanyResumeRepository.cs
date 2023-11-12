using Microsoft.EntityFrameworkCore;
using MyCareerServer.Company_Interfaces;
using MyCareerServer.CompanyModels;
using MyCareerServer.Data;

namespace MyCareerServer.Company_Repositories
{
    public class CompanyResumeRepository : ICompanyResumeRepository
    {
        private readonly ResumeDBContext _dbContext;

        public CompanyResumeRepository(ResumeDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<IEnumerable<CompanyResume>> GetCompanyResumes(int userId)
        {
            return await _dbContext.CompanyResumes.Where(c => c.User.Id == userId).ToListAsync();
        }

        public async Task<CompanyResume> GetCompanyResumeById(int id)
        {
            return await _dbContext.CompanyResumes.Where(cr => cr.Id == id).FirstOrDefaultAsync();
        }

        public bool Create(CompanyResume companyResume)
        {
            _dbContext.CompanyResumes.Add(companyResume);

            return Save();
        }

        public bool Update(CompanyResume companyResume)
        {
            _dbContext.CompanyResumes.Update(companyResume);

            return Save();
        }

        public bool Delete(int id)
        {
            var companyResume = _dbContext.CompanyResumes.Where(cr => cr.Id == id).FirstOrDefault();
            
            _dbContext.CompanyResumes.Remove(companyResume);

            return Save();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();

            return saved > 0 ? true : false;
        }
    }
}
