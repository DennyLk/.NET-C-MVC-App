using Newtonsoft.Json;
namespace W12C2_Demo_NewsApp.Models
{
    public class EmploymentTableModel
    {
        public string? Title { get; set; }
        public List<EmploymentInformation>? ProfessionalEmploymentInformation { get; set; }

        public static async Task<EmploymentTableModel?> GetViewModelAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string json = await httpClient.GetStringAsync("http://ist.rit.edu/api/employment/employmentTable");
                var response = JsonConvert.DeserializeObject<EmploymentTableModelView>(json);
                return response?.EmploymentTable; // This now correctly points to the nested EmploymentTableModel
            }
        }


    }

    public class EmploymentInformation
    {
        public string? Employer { get; set; }
        public string? Degree { get; set; }
        public string? City { get; set; }
        public string? Title { get; set; }
        public string? StartDate { get; set; }
    }
}
