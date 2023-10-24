using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Interfaces
{
    public interface IResumeRepository
    {
        Task<IEnumerable<Resume>> GetResumesByEmailAsync(string email);
        bool Create(Resume resume);
        bool Update(Resume resume);
        bool Delete(Resume resume);
        bool Save();
    }
}
