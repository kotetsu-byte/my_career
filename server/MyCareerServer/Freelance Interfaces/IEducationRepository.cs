using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Interfaces;

public interface IEducationRepository
{
    Task<IEnumerable<Education>> GetEducations(int resumeId);
    bool Create(Education education);
    bool Update(Education education);
    bool Delete(int id);
    bool Save();
}
