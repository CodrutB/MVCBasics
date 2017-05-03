using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Index()
        {
            ViewBag.Message = "My Games";
            return View();
        }
    }
}