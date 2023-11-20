using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCareerServer.Dtos;
using MyCareerServer.Freelance_Interfaces;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Freelance_Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly IEducationRepository _educationRepository;
        private readonly IMapper _mapper;

        public EducationController(IEducationRepository educationRepository, IMapper mapper)
        {
            _educationRepository = educationRepository;
            _mapper = mapper;
        }

        [HttpGet("{resumeId}")]
        public async Task<IActionResult> GetEducation(int resumeId)
        {
            var educations = _mapper.Map<List<EducationDto>>(await _educationRepository.GetEducations(resumeId));

            return Ok(educations);
        }

        [HttpPost]
        public IActionResult CreateEducation([FromBody] EducationDto educationDto)
        {
            var education = _mapper.Map<Education>(educationDto);

            _educationRepository.Create(education);

            return Ok("Successful");
        }

        [HttpPost("Update")]
        public IActionResult UpdateEducation([FromBody] EducationDto educationDto)
        {
            var education = _mapper.Map<Education>(educationDto);

            _educationRepository.Update(education);

            return Ok("Successful");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEducation(int id)
        {
            _educationRepository.Delete(id);

            return Ok("Successful");
        }
    }
}
