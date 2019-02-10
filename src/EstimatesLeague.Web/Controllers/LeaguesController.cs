using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EstimatesLeague.Web.Controllers
{
    [Authorize]
    public class LeaguesController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
