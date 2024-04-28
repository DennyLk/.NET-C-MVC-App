namespace W12C2_Demo_NewsApp.Models
{
    public class UndergraduateViewModel
    {
        public IEnumerable<UndergraduateDegree>? Undergraduate { get; set; }
    }

    public class UndergraduateDegree
    {
        public string? DegreeName { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string[]? Concentrations { get; set; }
    }
}
