using System.Web.Mvc;

namespace LeagueTest.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Age(string id)
        {
            ViewBag.ID = id;
            return View("AgeView");
        }
    }
}