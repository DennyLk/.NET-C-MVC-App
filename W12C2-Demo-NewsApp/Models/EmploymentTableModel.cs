using Newtonsoft.Json;
namespace W12C2_Demo_NewsApp.Models
{
    // Model class for the Employment Table
    public class EmploymentTableModel
    {
        // Properties to hold the title and professional employment information
        public string? Title { get; set; }
        public List<EmploymentInformation>? ProfessionalEmploymentInformation { get; set; }

        // Method to asynchronously fetch the view model
        public static async Task<EmploymentTableModel?> GetViewModelAsync()
        {
            // Using HttpClient to make a GET request to the API endpoint
            using (var httpClient = new HttpClient())
            {
                // Getting the JSON response from the API
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/employment/employmentTable");
                // Deserializing the JSON response into the EmploymentTableModelView object
                var response = JsonConvert.DeserializeObject<EmploymentTableModelView>(json);
                // Returning the EmploymentTable property of the response
                return response?.EmploymentTable;
            }
        }
    }

    // Class to represent employment information
    public class EmploymentInformation
    {
        // Properties for employer, degree, city, title, and start date
        public string? Employer { get; set; }
        public string? Degree { get; set; }
        public string? City { get; set; }
        public string? Title { get; set; }
        public string? StartDate { get; set; }
    }
}
