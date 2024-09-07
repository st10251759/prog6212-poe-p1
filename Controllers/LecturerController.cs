using Microsoft.AspNetCore.Mvc;

namespace Prog6212_POE_Demo_P1.Controllers
{
    public class LecturerController : Controller
    {
       
        public IActionResult SubmitClaim()
        {
            return View();
        }

        public IActionResult dashboard()
        {
            return View();
        }
    }
}
