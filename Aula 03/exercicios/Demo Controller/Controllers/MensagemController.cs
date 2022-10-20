using Microsoft.AspNetCore.Mvc;

//[Route("Mensagem")]
public class MensagemController : Controller
{
    // [Route("Exibir")]
    [HttpGet]
    public IActionResult Exibir()
    {
        return Content("<h1>Olá Mundo! Ass: Controller!</h1>","text/HTML");
    }
}