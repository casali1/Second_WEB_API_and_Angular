using System.Web.Mvc;

namespace Second_WEB_API_and_Angular.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}