using Newtonsoft.Json;

namespace W12C2_Demo_NewsApp.Models
{
    // Model class to represent undergraduate degrees
    public class UndergraduateModel
    {
        // Method to asynchronously retrieve undergraduate degree data
        public static async Task<IEnumerable<UndergraduateDegree>?> GetViewModelAsync()
        {
            using (var httpClient = new HttpClient())
            {
                // Fetch JSON data from the API
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/degrees/undergraduate");
                // Deserialize JSON into the model response
                var result = JsonConvert.DeserializeObject<UndergraduateModelResponse>(json);
                // Return the undergraduate degree data
                return result?.Undergraduate;
            }
        }
    }

    // Model class to represent the response from the API
    public class UndergraduateModelResponse
    {
        // Collection of undergraduate degrees
        public IEnumerable<UndergraduateDegree>? Undergraduate { get; set; }
    }
}
