using Newtonsoft.Json;

namespace W12C2_Demo_NewsApp.Models
{
    // Model class to represent news data
    public class NewsModel
    {
        // Date of the news
        public string? Date { get; set; }

        // Title of the news
        public string? Title { get; set; }

        // Description of the news
        public string? Description { get; set; }

        // Method to asynchronously retrieve the view model for news
        public static async Task<NewsViewModel?> GetViewModelAsync()
        {
            // Fetch JSON data from the specified URL
            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/news");

            // Deserialize JSON data into NewsViewModel object
            return JsonConvert.DeserializeObject<NewsViewModel>(json);
        }
    }
}
