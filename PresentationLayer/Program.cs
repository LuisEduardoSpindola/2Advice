using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using InfraestructureLayer.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var Conn = builder.Configuration.GetConnectionString("Conn");

builder.Services.AddDbContext<AdvContext>(options => options.UseSqlServer(Conn));

builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AdvContext>();
builder.Services.AddDbContext<AdvContext>(options => options.UseSqlServer(Conn));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapRazorPages();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
