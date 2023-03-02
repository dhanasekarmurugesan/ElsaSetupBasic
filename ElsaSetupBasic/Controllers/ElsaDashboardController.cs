using Microsoft.AspNetCore.Mvc;

namespace ElsaSetupBasic.Controllers
{
    public class ElsaDashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Workflow";
            return View();
        }
    }
}
