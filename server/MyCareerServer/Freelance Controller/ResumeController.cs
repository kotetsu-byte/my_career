using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCareerServer.Dtos;
using MyCareerServer.Freelance_Interfaces;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IResumeRepository _resumeRepository;
        private readonly IMapper _mapper;

        public ResumeController(IResumeRepository resumeRepository, IEducationRepository educationRepository, IMapper mapper)
        {
            _resumeRepository = resumeRepository;
            _mapper = mapper;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetResumesByEmail(string email)
        {
            var resumesDto = _mapper.Map<ResumeDto>(await _resumeRepository.GetResumesByEmailAsync(email));
            
            return Ok(resumesDto);
        }

        [HttpPost]
        public IActionResult CreateResume([FromBody] ResumeDto resumeDto)
        {
            var resume = _mapper.Map<Resume>(resumeDto);

            _resumeRepository.Create(resume);
            return Ok(resume.Id);
        }

        [HttpPut]
        public IActionResult UpdateResume([FromBody] ResumeDto resumeDto)
        {
            var resume = _mapper.Map<Resume>(resumeDto);
            
            _resumeRepository.Update(resume);

            return Ok("Succeeded");
        }

        [HttpDelete]
        public IActionResult DeleteResume([FromBody] ResumeDto resumeDto)
        {
            var resume = _mapper.Map<Resume>(resumeDto);
            
            _resumeRepository.Delete(resume);

            return Ok("Succeeded");
        }
    }
}
