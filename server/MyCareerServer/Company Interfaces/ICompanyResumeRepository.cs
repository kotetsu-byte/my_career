using MyCareerServer.CompanyModels;

namespace MyCareerServer.Company_Interfaces
{
    public interface ICompanyResumeRepository
    {
        Task<IEnumerable<CompanyResume>> GetCompanyResumes(int userId);
        Task<CompanyResume> GetCompanyResumeById(int id);
        bool Create(CompanyResume companyResume);
        bool Update(CompanyResume companyResume);
        bool Delete(int id);
        bool Save();
    }
}
