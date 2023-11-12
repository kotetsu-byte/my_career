using Microsoft.EntityFrameworkCore;
using MyCareerServer.Data;
using MyCareerServer.Freelance_Interfaces;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly ResumeDBContext _dbContext;

        public LanguageRepository(ResumeDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<IEnumerable<Language>> GetLanguages(int id)
        {
            return await _dbContext.Languages.Where(l => l.Id == id).ToListAsync();
        }

        public bool Create(Language language)
        {
            _dbContext.Languages.Add(language);

            return Save();
        }

        public bool Update(Language language)
        {
            _dbContext.Languages.Update(language);

            return Save();
        }

        public bool Delete(int id)
        {
            var language = _dbContext.Languages.Where(l => l.Id == id).FirstOrDefault();
            _dbContext.Languages.Remove(language);

            return Save();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();

            return saved > 0 ? true : false;
        }
    }
}
