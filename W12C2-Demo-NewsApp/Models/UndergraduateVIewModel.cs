namespace W12C2_Demo_NewsApp.Models
{
    // ViewModel class for representing undergraduate degree data
    public class UndergraduateViewModel
    {
        // Collection of undergraduate degrees
        public IEnumerable<UndergraduateDegree>? Undergraduate { get; set; }
    }

    // Class representing an undergraduate degree
    public class UndergraduateDegree
    {
        // Name of the degree
        public string? DegreeName { get; set; }
        // Title of the degree
        public string? Title { get; set; }
        // Description of the degree
        public string? Description { get; set; }
        // Array of concentrations within the degree
        public string[]? Concentrations { get; set; }
    }
}
