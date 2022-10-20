using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Content("<h3>Olá Mundo! Ass: Home Controller!","text/HTML");
    }
}