var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();


app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Mensagem}/{action=Exibir}/{id?}"
);


app.MapControllers();
app.Run();


