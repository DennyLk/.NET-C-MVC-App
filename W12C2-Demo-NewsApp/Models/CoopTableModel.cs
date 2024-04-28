using Newtonsoft.Json;
namespace W12C2_Demo_NewsApp.Models
{
    public class CoopTableModel
    {
        public string? Title { get; set; }
        public List<CoopInformation>? CoopInformation { get; set; }

        public static async Task<CoopTableModel?> GetViewModelAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/employment/coopTable");
                var result = JsonConvert.DeserializeObject<CoopTableViewModel>(json);
                return result?.CoopTable;
            }
        }
    }

    public class CoopInformation
    {
        public string? Employer { get; set; }
        public string? Degree { get; set; }
        public string? City { get; set; }
        public string? Term { get; set; }
    }
}
