using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddAuthentication("loginSchema").AddCookie("loginSchema"
    , options =>
    {
        options.LoginPath = "/Login";
        options.AccessDeniedPath = "/Login/AcessoNegado";
    }
    );

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Administrador", policy =>
    {
        policy.RequireClaim("Perfil", "Administrador");
    });
});

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}"
//);

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory())
});

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapDefaultControllerRoute();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.UseSession();

app.MapControllers();
app.Run();
