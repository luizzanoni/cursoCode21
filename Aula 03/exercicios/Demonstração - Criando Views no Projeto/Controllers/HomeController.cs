using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        var segundos = DateTime.Now.Second;

        if (segundos % 2 != 0)
            return View("Outra");
        else
            return View();
    }
}