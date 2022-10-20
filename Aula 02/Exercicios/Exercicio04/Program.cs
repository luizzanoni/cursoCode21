using System.Net.Mime;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/Nome", () => "Digite seu nome completo na URL");

app.MapGet("/Nome/{nome}", (string nome) => ValidaNomeCompleto(nome));


app.Run();


IResult ValidaNomeCompleto(string nome)
{
    if (nome.Split(" ").Length == 1)
    {
        return Results.Problem("É necessário informar o sobrenome");
    }
    else
        return Results.Text("<h2>Obrigado " + nome + "</h2>", "text/HTML");
}