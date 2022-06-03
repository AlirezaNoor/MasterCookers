using Mc.Application;
using Mc.Application.CookesCategoryApplications;
using Mc.ApplicationContracts.CookesCategory;
using CookesCategores;
using Mc.Insfrastucture.CookesReposetories;
using Mc.Insfrastucture.DbContext;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("MasterCooker")));

builder.Services.AddTransient<ICookesCategoryReposetory, CookesCategoryReposetory>();
builder.Services.AddTransient<ICookesCategoryApplication, CookesCategoryApplication>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
