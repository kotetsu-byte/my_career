using MyCareerServer.FreelanceModels;

namespace MyCareerServer.Dtos
{
    public class LanguageDto
    {
        public int? Id { get; set; }
        public string? Lang { get; set; }
        public string? Level { get; set; }
        public int? ResumeId { get; set; }
    }
}
