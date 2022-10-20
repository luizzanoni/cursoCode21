using Catalogo.MeuNamespace;
using Microsoft.AspNetCore.Mvc;

public class FilmeController : Controller
{

    public IActionResult Index()
    {
        List<Filme> listaFilmes = new List<Filme>();

        listaFilmes.Add(new Filme { Codigo = 1, Titulo = "De Volta para o Futuro", Sinopse = "Viagem no Tempo", Lancamento = new DateTime(1985, 10, 20) });
        listaFilmes.Add(new Filme { Codigo = 2, Titulo = "O Sexto Sentido", Sinopse = "Vida após a morte", Lancamento = new DateTime(1990, 10, 20) });
        listaFilmes.Add(new Filme { Codigo = 3, Titulo = "Top Gun", Sinopse = "Filme sobre Guerra", Lancamento = new DateTime(1985, 10, 20) });

        return View(listaFilmes);
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Salvar(Filme filme)
    {

        if (string.IsNullOrEmpty(filme.Titulo))
        {
            ViewBag.Mensagem = "O campo Titulo deve ser preenchido";
            return View("Cadastro");
        }
        else
        {
            List<Filme> listaFilmes = new List<Filme>();

            listaFilmes.Add(new Filme { Codigo = 1, Titulo = "De Volta para o Futuro", Sinopse = "Viagem no Tempo", Lancamento = new DateTime(1985, 10, 20) });
            listaFilmes.Add(new Filme { Codigo = 2, Titulo = "O Sexto Sentido", Sinopse = "Vida após a morte", Lancamento = new DateTime(1990, 10, 20) });
            listaFilmes.Add(new Filme { Codigo = 3, Titulo = "Top Gun", Sinopse = "Filme sobre Guerra", Lancamento = new DateTime(1985, 10, 20) });


            return View("Index", listaFilmes);
        }

    }

}