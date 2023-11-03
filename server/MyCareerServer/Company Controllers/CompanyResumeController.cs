using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCareerServer.Company_Interfaces;
using MyCareerServer.CompanyModels;
using MyCareerServer.Dtos;

namespace MyCareerServer.Company_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyResumeController : ControllerBase
    {
        private readonly ICompanyResumeRepository _companyResumeRepository;
        private readonly IMapper _mapper;

        public CompanyResumeController(ICompanyResumeRepository companyResumeRepository, IMapper mapper)
        {
            _companyResumeRepository = companyResumeRepository;
            _mapper = mapper;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetCompanyResumes(string email)
        {
            var resumes = _mapper.Map<CompanyResumeDto>(await _companyResumeRepository.GetCompanyResumesByEmail(email));

            return Ok(resumes);
        }

        [HttpPost]
        public IActionResult CreateCompanyResumes([FromBody]  CompanyResumeDto companyResumeDto)
        {
            var resume = _mapper.Map<CompanyResume>(companyResumeDto);

            _companyResumeRepository.Create(resume);

            return Ok("Successful");
        }

        [HttpPut]
        public IActionResult UpdateCompanyResume([FromBody] CompanyResumeDto companyResumeDto)
        {
            var resume = _mapper.Map<CompanyResume>(companyResumeDto);

            _companyResumeRepository.Update(resume);

            return Ok("Successful");
        }

        [HttpDelete]
        public IActionResult DeleteCompanyResume([FromBody] CompanyResumeDto companyResumeDto)
        {
            var resume = _mapper.Map<CompanyResume>(companyResumeDto);

            _companyResumeRepository.Delete(resume);

            return Ok("Successful");
        }
    }
}
