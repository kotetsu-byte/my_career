using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Interfaces
{
    public interface IEducationRepository
    {
        Task<IEnumerable<Education>> GetEducationsById(int id);

    }
}
