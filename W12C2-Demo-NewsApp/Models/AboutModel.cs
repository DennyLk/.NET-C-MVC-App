using Newtonsoft.Json;


namespace W12C2_Demo_NewsApp.Models
{
    public class AboutModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Quote { get; set; }
        public string? QuoteAuthor { get; set; }

        public static async Task<AboutModel?> GetAboutModelAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync("https://ischool.gccis.rit.edu/api/about");
                return JsonConvert.DeserializeObject<AboutModel>(json);
            }
        }
    }
}
