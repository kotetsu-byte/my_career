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
        private readonly IContactRepository _contactRepository;
        private readonly IEducationRepository _educationRepository;
        private readonly IExperienceRepository _experienceRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly IMapper _mapper;

        public ResumeController(IResumeRepository resumeRepository, IEducationRepository educationRepository, IMapper mapper)
        {
            _resumeRepository = resumeRepository;
            _educationRepository = educationRepository;
            _mapper = mapper;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetResumesByEmail(string email)
        {
            var resumes = _resumeRepository.GetResumesByEmailAsync(email);
            return Ok(resumes);
        }

        [HttpPost]
        public IActionResult CreateResume([FromBody] ResumeDto resumeDto)
        {
            var resume = _mapper.Map<Resume>(resumeDto);

            _resumeRepository.Create(resume);
            return Ok(resume.Id);
        }

        [HttpPut]
        public IActionResult UpdateResume([FromBody] Resume resume)
        {
            _resumeRepository.Update(resume);

            return Ok("Succeeded");
        }

        [HttpDelete]
        public IActionResult DeleteResume([FromBody] Resume resume)
        {
            _resumeRepository.Delete(resume);

            return Ok("Succeeded");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactsById(int id)
        {
            var contacts = await _contactRepository.GetContacts(id);

            return Ok(contacts);
        }
    }
}
