using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tracker.Controllers
{
    [Authorize]
    public class TrackerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
