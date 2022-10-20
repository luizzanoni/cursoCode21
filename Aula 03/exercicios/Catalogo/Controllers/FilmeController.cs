using Microsoft.AspNetCore.Mvc;

public class FilmeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Cadastro()
    {
        return View();
    }

}