namespace W12C2_Demo_NewsApp.Models
{
    public class GraduateViewModel
    {
        public Graduate[]? graduate { get; set; }
    }

    public class Graduate
    {
        public string? DegreeName { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string[]? Concentrations { get; set; }
        public string[]? AvailableCertificates { get; set; }
    }
}
