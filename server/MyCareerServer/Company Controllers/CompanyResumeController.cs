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

        [HttpGet("all/{userId}")]
        public async Task<IActionResult> GetCompanyResumes(int userId)
        {
            var resumes = await _companyResumeRepository.GetCompanyResumes(userId);

            return Ok(resumes);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyResumeById(int id)
        {
            var resume = _mapper.Map<CompanyResumeDto>(await _companyResumeRepository.GetCompanyResumeById(id));

            return Ok(resume);
        }

        [HttpPost]
        public IActionResult CreateCompanyResumes([FromBody] CompanyResumeDto companyResumeDto)
        {
            var resume = _mapper.Map<CompanyResume>(companyResumeDto);
            _companyResumeRepository.Create(resume);

            return Ok("Successful");
        }

        [HttpPatch]
        public IActionResult UpdateCompanyResume([FromBody] CompanyResumeDto companyResumeDto)
        {
            var resume = _mapper.Map<CompanyResume>(companyResumeDto);
            _companyResumeRepository.Update(resume);

            return Ok("Successful");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCompanyResume(int id)
        {
            _companyResumeRepository.Delete(id);

            return Ok("Successful");
        }
    }
}
