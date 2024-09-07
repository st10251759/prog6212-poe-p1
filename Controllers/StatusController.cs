using Microsoft.AspNetCore.Mvc;

namespace Prog6212_POE_Demo_P1.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult TrackStatus()
        {
            return View();
        }
    }
}
