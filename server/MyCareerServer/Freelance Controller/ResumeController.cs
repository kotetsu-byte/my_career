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

        [HttpGet("all/{userId}")]
        public async Task<IActionResult> GetResumesByEmail(int userId)
        {
            var resumes = await _resumeRepository.GetResumes(userId);

            return Ok(resumes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetResumeById(int id)
        {
            var resumeDto = _mapper.Map<ResumeDto>(await _resumeRepository.GetResumeById(id));

            return Ok(resumeDto);
        }

        [HttpPost]
        public IActionResult CreateResume([FromBody] ResumeDto resumeDto)
        {
            var resume = _mapper.Map<Resume>(resumeDto);
            _resumeRepository.Create(resume);
            return Ok(resume.Id);
        }

        [HttpPatch]
        public IActionResult UpdateResume([FromBody] ResumeDto resumeDto)
        {
            var resume = _mapper.Map<Resume>(resumeDto);
            _resumeRepository.Update(resume);
            return Ok(resume.Id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteResume(int id)
        {
            _resumeRepository.Delete(id);

            return Ok("Succeeded");
        }
    }
}
