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

        // GET: Games
        public ActionResult GetGamesJson()
        {
            return Json(new object[] {new {Name = "Dark Souls", Price = 10}, new {Name = "God of War", Price = 12}},
                JsonRequestBehavior.AllowGet);
        }
    }
}