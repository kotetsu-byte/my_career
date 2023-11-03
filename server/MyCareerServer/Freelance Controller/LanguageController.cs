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
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IMapper _mapper;

        public LanguageController(ILanguageRepository languageRepository, IMapper mapper)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
        }

        [HttpGet("{resumeId}")]
        public async Task<IActionResult> GetLanguages(int resumeId)
        {
            var languages = _mapper.Map<LanguageDto>(await _languageRepository.GetLanguages(resumeId));

            return Ok(languages);
        }

        [HttpPost]
        public IActionResult CreateLanguage([FromBody] LanguageDto languageDto) 
        {
            var language = _mapper.Map<Language>(languageDto);

            _languageRepository.Create(language);

            return Ok("Successful");
        }

        [HttpPut]
        public IActionResult UpdateLanguage([FromBody] LanguageDto languageDto)
        {
            var language = _mapper.Map<Language>(languageDto);

            _languageRepository.Update(language);

            return Ok("Successful");
        }

        [HttpDelete]
        public IActionResult DeleteLanguage([FromBody] LanguageDto languageDto)
        {
            var language = _mapper.Map<Language>(languageDto);

            _languageRepository.Delete(language);

            return Ok("Successful");
        }
    }
}
