using Newtonsoft.Json;
using System.Net.Http; // Importing HttpClient namespace for making HTTP requests
using System.Threading.Tasks; // Importing Task namespace for asynchronous programming

namespace W12C2_Demo_NewsApp.Models
{
    public class AboutModel
    {
        // Properties for the AboutModel
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Quote { get; set; }
        public string? QuoteAuthor { get; set; }

        // Method to asynchronously obtain the AboutModel data from an API
        public static async Task<AboutModel?> GetAboutModelAsync()
        {
            // Using HttpClient to make an HTTP GET request
            using (HttpClient client = new HttpClient())
            {
                // Getting the JSON string asynchronously from the API
                string json = await client.GetStringAsync("https://ischool.gccis.rit.edu/api/about");
                // Deserializing the JSON string into an instance of AboutModel and returning it
                return JsonConvert.DeserializeObject<AboutModel>(json);
            }
        }
    }
}
