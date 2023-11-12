using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Interfaces
{
    public interface IResumeRepository
    {
        Task<IEnumerable<Resume>> GetResumes(int userId);
        Task<Resume> GetResumeById(int id);
        bool Create(Resume resume);
        bool Update(Resume resume);
        bool Delete(int id);
        bool Save();
    }
}
