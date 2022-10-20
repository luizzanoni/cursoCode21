using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.MensagemDeBoasVindas = "SEJA BEM VINDO DA VIEWBAG";

        return View();
    }
}