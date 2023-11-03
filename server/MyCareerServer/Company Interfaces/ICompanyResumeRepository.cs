using MyCareerServer.CompanyModels;

namespace MyCareerServer.Company_Interfaces
{
    public interface ICompanyResumeRepository
    {
        Task<IEnumerable<CompanyResume>> GetCompanyResumesByEmail(string email);
        bool Create(CompanyResume companyResume);
        bool Update(CompanyResume companyResume);
        bool Delete(CompanyResume companyResume);
        bool Save();
    }
}
