using Newtonsoft.Json;

namespace W12C2_Demo_NewsApp.Models
{
    // Model class for CoopTable data
    public class CoopTableModel
    {
        // Title of the Coop Table
        public string? Title { get; set; }

        // List of CoopInformation objects
        public List<CoopInformation>? CoopInformation { get; set; }

        // Method to asynchronously fetch and deserialize CoopTable data from the API
        public static async Task<CoopTableModel?> GetViewModelAsync()
        {
            // Using HttpClient to send HTTP requests and receive HTTP responses
            using (var httpClient = new HttpClient())
            {
                // Sending a GET request to the API endpoint
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/employment/coopTable");

                // Deserializing the JSON response into a CoopTableViewModel object
                var result = JsonConvert.DeserializeObject<CoopTableViewModel>(json);

                // Returning the CoopTable property of the deserialized result
                return result?.CoopTable;
            }
        }
    }

    // Model class for Coop Information
    public class CoopInformation
    {
        // Name of the employer
        public string? Employer { get; set; }

        // Degree associated with the co-op
        public string? Degree { get; set; }

        // City where the co-op is located
        public string? City { get; set; }

        // Term of the co-op
        public string? Term { get; set; }
    }
}
