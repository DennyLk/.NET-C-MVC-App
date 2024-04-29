using Newtonsoft.Json;

namespace W12C2_Demo_NewsApp.Models
{
    // Model class to represent graduate degree data
    public class GraduateModel
    {
        // Method to asynchronously retrieve and deserialize graduate degree data
        public static async Task<GraduateViewModel?> GetViewModelAsync()
        {
            // Using HttpClient to make HTTP GET request to the specified URL
            using (var httpClient = new HttpClient())
            {
                // Getting JSON data from the specified URL
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/degrees/graduate");

                // Deserializing JSON data into a GraduateViewModel object
                var result = JsonConvert.DeserializeObject<GraduateViewModel>(json);

                // Returning the deserialized GraduateViewModel object
                return result;
            }
        }
    }
}
