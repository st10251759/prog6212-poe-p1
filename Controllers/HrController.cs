using Microsoft.AspNetCore.Mvc;

namespace Prog6212_POE_Demo_P1.Controllers
{
    public class HrController : Controller
    {
        public IActionResult dashboard()
        {
            return View();
        }

        public IActionResult ProcessPayments()
        {
            return View();
        }

        public IActionResult GenerateReport()
        {
            return View();
        }
    }
}
