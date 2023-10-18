namespace MyCareerServer.FreelanceModels
{
    public class Resume
    {
        public int? Id { get; set; }
        public HeadInfo? HeadInfo { get; set; }
        public IEnumerable<Language>? Languages { get; set; }
        public IEnumerable<Experience>? Experinces { get; set; }
        public IEnumerable<Contact>? Contacts { get; set; }
    }
}
