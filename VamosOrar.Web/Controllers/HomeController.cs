using System.Web.Mvc;
using VamosOrar.Data.Services;

namespace VamosOrar.Web.Controllers
{
    public class HomeController : Controller
    {
        IPedidosOracoesData db;

        public HomeController(IPedidosOracoesData db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult Dashboard()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult SOS()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}