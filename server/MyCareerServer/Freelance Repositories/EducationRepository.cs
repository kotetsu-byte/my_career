using Microsoft.EntityFrameworkCore;
using MyCareerServer.Data;
using MyCareerServer.Freelance_Interfaces;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Repositories
{
    public class EducationRepository : IEducationRepository
    {
        private readonly ResumeDBContext _dbContext;

        public EducationRepository(ResumeDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<IEnumerable<Education>> GetEducations(int id)
        {
            return await _dbContext.Educations.Where(e => e.ResumeId == id).ToListAsync();
        }

        public bool Create(Education education)
        {
            _dbContext.Educations.Add(education);

            return Save();
        }

        public bool Update(Education education)
        {
            _dbContext.Educations.Update(education);

            return Save();
        }

        public bool Delete(int id)
        {
            var education = _dbContext.Educations.Where(e => e.Id == id).FirstOrDefault();
            _dbContext.Educations.Remove(education);

            return Save();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();

            return saved > 0 ? true : false;
        }
    }
}
