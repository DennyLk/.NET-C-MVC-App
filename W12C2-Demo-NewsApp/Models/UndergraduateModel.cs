using Newtonsoft.Json;

namespace W12C2_Demo_NewsApp.Models
{

    public class UndergraduateModel
    {
        public static async Task<IEnumerable<UndergraduateDegree>?> GetViewModelAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/degrees/undergraduate");
                var result = JsonConvert.DeserializeObject<UndergraduateModelResponse>(json);
                return result?.Undergraduate;
            }
        }
    }


    public class UndergraduateModelResponse
    {
        public IEnumerable<UndergraduateDegree>? Undergraduate { get; set; }
    }
}
