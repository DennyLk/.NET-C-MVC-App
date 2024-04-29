using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace W12C2_Demo_NewsApp.Models
{
    // Model class to represent faculty information
    public class FacultyModel
    {
        // Properties to store faculty details
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? Tagline { get; set; }
        public string? ImagePath { get; set; }
        public string? Title { get; set; }
        public string? InterestArea { get; set; }
        public string? Office { get; set; }
        public string? Website { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Twitter { get; set; }
        public string? Facebook { get; set; }

        // Method to asynchronously retrieve faculty view model
        public static async Task<FacultyViewModel?> GetViewModelAsync()
        {
            // Using HttpClient to make HTTP requests
            using (var httpClient = new HttpClient())
            {
                // Retrieving JSON data from the API
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/people/faculty");
                // Deserialize JSON data into FacultyViewModel object
                return JsonConvert.DeserializeObject<FacultyViewModel>(json);
            }
        }
    }
}
