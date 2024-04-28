using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace W12C2_Demo_NewsApp.Models
{
    public class GraduateModel
    {
        public static async Task<GraduateViewModel?> GetViewModelAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/degrees/graduate");
                var result = JsonConvert.DeserializeObject<GraduateViewModel>(json);
                return result;
            }
        }
    }
}
