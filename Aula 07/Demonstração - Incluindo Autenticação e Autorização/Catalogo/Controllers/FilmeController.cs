using Catalogo.MeuNamespace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;

public class FilmeController : Controller
{

    public IMemoryCache _memCache;

    public FilmeController(IMemoryCache memoryCache)
    {
        _memCache = memoryCache;
    }

    public IActionResult Index()
    {
        List<Filme> listaFilmes = new List<Filme>();

        if (_memCache.Get("ListaFilmes") == null)
        {

            listaFilmes.Add(new Filme { Codigo = 1, Titulo = "De Volta para o Futuro", Sinopse = "Viagem no Tempo", Lancamento = new DateTime(1985, 10, 20) });
            listaFilmes.Add(new Filme { Codigo = 2, Titulo = "O Sexto Sentido", Sinopse = "Vida após a morte", Lancamento = new DateTime(1990, 10, 20) });
            listaFilmes.Add(new Filme { Codigo = 3, Titulo = "Top Gun", Sinopse = "Filme sobre Guerra", Lancamento = new DateTime(1985, 10, 20) });


            _memCache.Set("ListaFilmes", listaFilmes, TimeSpan.FromMinutes(5));
        }
        else
        {
            listaFilmes = (List<Filme>)_memCache.Get("ListaFilmes");
        }

        return View(listaFilmes);
    }

    public IActionResult Cadastro()
    {

        List<SelectListItem> listaCategoria = new List<SelectListItem>{
            new SelectListItem {Text="Ação",Value="Ação"},
            new SelectListItem {Text="Terror",Value="Terror"},
            new SelectListItem {Text="Drama",Value="Drama"}
         };

        ViewBag.Categorias = listaCategoria;

        return View();
    }

    [HttpPost]
    public IActionResult Salvar(Filme filme)
    {

        if (ModelState.IsValid)
        {


            List<Filme> listaFilmes = (List<Filme>)_memCache.Get("ListaFilmes");

            listaFilmes.Add(filme);

            return View("Index", listaFilmes);
        }
        else
        {

            ViewBag.Mensagem = "Erro ao salvar um Filme, verifique os campos";
            return View("Cadastro");
        }




    }

    public IActionResult Editar(int Id)
    {
        List<Filme> listaFilmes = (List<Filme>)_memCache.Get("ListaFilmes");

        Filme filme = listaFilmes.Find(f => f.Codigo == Id);

        return View("Cadastro", filme);

    }

}