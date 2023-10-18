using System.ComponentModel.DataAnnotations.Schema;

namespace MyCareerServer.FreelanceModels
{
    public class Address
    {
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? Street { get; set; }
        [ForeignKey("HeadInfo")]
        public int? HeadInfoId { get; set; }
        public HeadInfo? HeadInfo { get; set; }
    }
}
