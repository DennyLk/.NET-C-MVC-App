using Newtonsoft.Json;

namespace W12C2_Demo_NewsApp.Models
{

    public class NewsModel
    {
        public string? Date { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public static async Task<NewsViewModel?> GetViewModelAsync()
        {

            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/news");
            return JsonConvert.DeserializeObject<NewsViewModel>(json);
        }
    }



}
