using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCareerServer.Freelance_Interfaces;
using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelanceController : ControllerBase
    {
        private readonly IResumeRepository _resumeRepository;

        public FreelanceController(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetResumesByEmail(string email)
        {
            var resumes = _resumeRepository.GetResumesByEmailAsync(email);

            return Ok(resumes);
        }

        [HttpPost]
        public IActionResult CreateResume([FromBody] Resume resume)
        {
            _resumeRepository.Create(resume);

            return Ok("Succeeded");
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
    }
}
