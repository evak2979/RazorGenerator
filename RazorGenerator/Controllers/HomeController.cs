using System.Web.Mvc;
using PreCompiledLibrary.Models;

namespace RazorGenerator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new TestModel() {IsTrue = false});
        }
    }
}