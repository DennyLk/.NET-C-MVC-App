using Newtonsoft.Json;
namespace W12C2_Demo_NewsApp.Models
{
    public class FacultyModel
    {
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

        public static async Task<FacultyViewModel?> GetViewModelAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/people/faculty");
                return JsonConvert.DeserializeObject<FacultyViewModel>(json);
            }
        }
    }
}
