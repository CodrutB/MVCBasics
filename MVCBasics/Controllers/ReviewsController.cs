using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class ReviewsController : Controller
    {
        private static readonly List<GameReview> _reviews = new List<GameReview>
        {
            new GameReview
            {
                Id = 1,
                Company = "Blizzard",
                Name = "Diablo 3",
                ReviewerName = "Jason",
                Raiting = 7
            },
            new GameReview
            {
                Id = 2,
                Company = "CD Projekt Red",
                Name = "The Witcher 3",
                ReviewerName = "Mark",
                Raiting = 10
            },
            new GameReview
            {
                Id = 3,
                Company = "Valve",
                Name = "Dota 2",
                ReviewerName = "James",
                Raiting = 8
            }
        };

        // GET: Reviews2
        public ActionResult Index()
        {
            var model = from r in _reviews
                orderby r.Company
                select r;

            return View(model);
        }

        // GET: Reviews2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews2/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews2/Edit/5
        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(item => item.Id == id);
            return View(review);
        }

        // POST: Reviews2/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.Single(item => item.Id == id);
            try
            {
                if (TryUpdateModel(review))
                {

                    return RedirectToAction("Index");
                }

                return View(review);
            }
            catch
            {
                return View(review);
            }
        }

        // GET: Reviews2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews2/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}