using System.Web.Mvc;
using MVCBasics.Filters;

namespace MVCBasics.Controllers
{
    [Log]
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Index()
        {
            ViewBag.Message = "My Games";
            return View();
        }

        // GET: Games
        [Route("games/data")]
        public ActionResult GetGamesJson()
        {
            return Json(new object[] {new {Name = "Dark Souls", Price = 10}, new {Name = "God of War", Price = 12}},
                JsonRequestBehavior.AllowGet);
        }
    }
}