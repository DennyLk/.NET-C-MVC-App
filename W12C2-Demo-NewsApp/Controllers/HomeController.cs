using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using W12C2_Demo_NewsApp.Models;
using System.Threading.Tasks; // Importing Task namespace for asynchronous programming


namespace W12C2_Demo_NewsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructor injection of ILogger<HomeController> for logging purposes
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action method for rendering the Index view
        public IActionResult Index()
        {
            return View();
        }

        // Action method for rendering the News view asynchronously
        public async Task<IActionResult> News()
        {
            // Returning the News view with the ViewModel obtained asynchronously
            return View(await NewsModel.GetViewModelAsync());
        }

        // Action method for rendering the About view asynchronously
        public async Task<IActionResult> About()
        {
            // Obtaining the AboutModel asynchronously
            var aboutModel = await AboutModel.GetAboutModelAsync();
            // Creating the ViewModel with the obtained AboutModel
            var viewModel = new AboutViewModel { About = aboutModel };
            // Returning the About view with the ViewModel
            return View(viewModel);
        }

        // Action method for rendering the Faculty view asynchronously
        public async Task<IActionResult> Faculty()
        {
            // Obtaining the ViewModel asynchronously
            var viewModel = await FacultyModel.GetViewModelAsync();
            // Returning the Faculty view with the obtained ViewModel
            return View(viewModel);
        }

        // Action method for rendering the Undergraduate view asynchronously
        public async Task<IActionResult> Undergraduate()
        {
            // Obtaining the UndergraduateModel asynchronously
            var undergraduateModel = await UndergraduateModel.GetViewModelAsync();
            // Creating the ViewModel with the obtained UndergraduateModel
            var viewModel = new UndergraduateViewModel { Undergraduate = undergraduateModel };
            // Returning the Undergraduate view with the ViewModel
            return View(viewModel);
        }

        // Action method for rendering the Graduate view asynchronously
        public async Task<IActionResult> Graduate()
        {
            // Obtaining the ViewModel asynchronously
            var viewModel = await GraduateModel.GetViewModelAsync();
            // Returning the Graduate view with the obtained ViewModel
            return View(viewModel);
        }

        // Action method for rendering the CoopTable view asynchronously
        public async Task<IActionResult> CoopTable()
        {
            // Obtaining the ViewModel asynchronously
            var viewModel = await CoopTableModel.GetViewModelAsync();
            // Returning the CoopTable view with the obtained ViewModel
            return View(new CoopTableViewModel { CoopTable = viewModel });
        }

        // Action method for rendering the EmploymentTable view asynchronously
        public async Task<IActionResult> EmploymentTable()
        {
            // Obtaining the ViewModel asynchronously
            var viewModel = await EmploymentTableModel.GetViewModelAsync();
            // Checking if the ViewModel or its ProfessionalEmploymentInformation is null or empty
            if (viewModel == null || viewModel.ProfessionalEmploymentInformation == null || !viewModel.ProfessionalEmploymentInformation.Any())
            {
                // Logging a warning if the employment data is empty or null
                _logger.LogWarning("Employment data is empty or null");
            }
            // Returning the EmploymentTable view with the obtained ViewModel
            return View(new EmploymentTableModelView { EmploymentTable = viewModel });
        }

        // Action method for rendering the Error view
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Returning the Error view with the ErrorViewModel
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
