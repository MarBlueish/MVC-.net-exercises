using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ativ9_Projeto.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Ativ9_ProjetoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Ativ9_ProjetoContext") ?? throw new InvalidOperationException("Connection string 'Ativ9_ProjetoContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
