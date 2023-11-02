using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Interfaces
{
    public interface IExperienceRepository
    {
        Task<IEnumerable<Experience>> GetExperiences(int resumeId);
        bool Create(Experience experience);
        bool Update(Experience experience);
        bool Delete(Experience experience);
        bool Save();
    }
}
