namespace W12C2_Demo_NewsApp.Models
{
    // ViewModel class to represent graduate degree data
    public class GraduateViewModel
    {
        // Array of Graduate objects representing graduate degree information
        public Graduate[]? graduate { get; set; }
    }

    // Class to represent individual graduate degree
    public class Graduate
    {
        // Name of the graduate degree
        public string? DegreeName { get; set; }

        // Title of the graduate degree
        public string? Title { get; set; }

        // Description of the graduate degree
        public string? Description { get; set; }

        // Array of concentrations available for the graduate degree
        public string[]? Concentrations { get; set; }

        // Array of available certificates for the graduate degree
        public string[]? AvailableCertificates { get; set; }
    }
}
