using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCareerServer.Freelance_Interfaces;

namespace MyCareerServer.Freelance_Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public ContactController(IContactRepository contactRepository, IMapper mapper)
        {
            _contactRepository = contactRepository;
            _mapper = mapper;
        }

        [HttpGet("{resumeId}")]
        public async Task<IActionResult> GetContacts(int resumeId)
        {
            var contacts = _contactRepository.GetContacts(resumeId);

            return Ok(contacts);
        }
    }
}
