using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Interfaces
{
    public interface IFreelanceRepository
    {
        Task<Resume> GetResumeByEmail(string email);
        bool Create(Resume resume);
        bool Update(Resume resume);
        bool Delete(Resume resume);
        bool Save();
    }
}
