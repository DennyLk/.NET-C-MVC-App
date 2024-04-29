namespace W12C2_Demo_NewsApp.Models
{
    // Model class to represent error information
    public class ErrorViewModel
    {
        // Property to hold the request ID associated with the error
        public string? RequestId { get; set; }

        // Property to determine if the request ID should be shown
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
