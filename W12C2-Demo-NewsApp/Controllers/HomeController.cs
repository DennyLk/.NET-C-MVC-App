using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using W12C2_Demo_NewsApp.Models;


namespace W12C2_Demo_NewsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> News()
        {
            return View(await NewsModel.GetViewModelAsync());
        }
       
        public async Task<IActionResult> About()
        {
            var aboutModel = await AboutModel.GetAboutModelAsync();
            var viewModel = new AboutViewModel { About = aboutModel };
            return View(viewModel);
        }

        public async Task<IActionResult> Faculty()
        {

            var viewModel = await FacultyModel.GetViewModelAsync();
            return View(viewModel);
        }


        public async Task<IActionResult> Undergraduate()
        {
            var undergraduateModel = await UndergraduateModel.GetViewModelAsync();
            var viewModel = new UndergraduateViewModel { Undergraduate = undergraduateModel };
            return View(viewModel);
        }


        public async Task<IActionResult> Graduate()
        {
            var viewModel = await GraduateModel.GetViewModelAsync();
            return View(viewModel);
        }


        public async Task<IActionResult> CoopTable()
        {
            var viewModel = await CoopTableModel.GetViewModelAsync();
            return View(new CoopTableViewModel { CoopTable = viewModel });
        }

        public async Task<IActionResult> EmploymentTable()
        {
            var viewModel = await EmploymentTableModel.GetViewModelAsync();
            if (viewModel == null || viewModel.ProfessionalEmploymentInformation == null || !viewModel.ProfessionalEmploymentInformation.Any())
            {
                _logger.LogWarning("Employment data is empty or null");
                // Optionally, you can return a different view or model here to handle the empty data scenario.
            }
            return View(new EmploymentTableModelView { EmploymentTable = viewModel });
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}