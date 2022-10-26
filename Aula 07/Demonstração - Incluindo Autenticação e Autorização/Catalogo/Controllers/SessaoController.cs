using Microsoft.AspNetCore.Mvc;

namespace Catalogo.Controllers
{
    public class SessaoController : Controller
    {
        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("DataDaSessao") == null)
                HttpContext.Session.SetString("DataDaSessao", DateTime.Now.ToString());

            ViewBag.DataDaSessao = HttpContext.Session.GetString("DataDaSessao");
            return View();
        }
    }
}
