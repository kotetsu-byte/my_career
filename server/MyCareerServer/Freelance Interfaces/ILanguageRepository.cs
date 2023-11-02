using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Interfaces
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<Language>> GetLanguages(int resumeId);
        bool Create(Language language);
        bool Update(Language language);
        bool Delete(Language language);
        bool Save();
    }
}
