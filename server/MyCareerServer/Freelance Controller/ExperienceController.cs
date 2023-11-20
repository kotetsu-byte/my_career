using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using MyCareerServer.Dtos;
using MyCareerServer.Freelance_Interfaces;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceRepository _experienceRepository;
        private readonly IMapper _mapper;

        public ExperienceController(IExperienceRepository experienceRepository, IMapper mapper)
        {
            _experienceRepository = experienceRepository;
            _mapper = mapper;
        }

        [HttpGet("{resumeId}")]
        public async Task<IActionResult> GetExperiences(int resumeId)
        {
            var experiences = _mapper.Map<List<ExperienceDto>>(await _experienceRepository.GetExperiences(resumeId));

            return Ok(experiences);
        }

        [HttpPost]
        public IActionResult CreateExperience([FromBody] ExperienceDto experienceDto) 
        { 
            var experience = _mapper.Map<Experience>(experienceDto);

            _experienceRepository.Create(experience);

            return Ok("Successful");
        }

        [HttpPost("Update")]
        public IActionResult UpdateExperience([FromBody] ExperienceDto experienceDto)
        {
            var experience = _mapper.Map<Experience>(experienceDto);

            _experienceRepository.Update(experience);

            return Ok("Successful");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteExperience(int id)
        {
            _experienceRepository.Delete(id);

            return Ok("Successful");
        }
    }
}
