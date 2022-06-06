using Mc.Application;
using Mc.Application.CookesCategoryApplications;
using Mc.ApplicationContracts.CookesCategory;
using CookesCategores;
using Mc.Application.CookesAplications;
using Mc.ApplicationContracts.Comment;
using Mc.ApplicationContracts.CookApplication;
using Mc.Domin.Comment;
using Mc.Domin.Cookes;
using Mc.Insfrastucture;
using Mc.Insfrastucture.CookesReposetories;
using Mc.Insfrastucture.DbContext;
using Mc.Query;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("MasterCooker")));

builder.Services.AddTransient<ICookesCategoryReposetory, CookesCategoryReposetory>();
builder.Services.AddTransient<ICookesCategoryApplication, CookesCategoryApplication>();
builder.Services.AddTransient<ICookesAplications, CookesAplications>();
builder.Services.AddTransient<ICookerReposetoy, CookerReposetoy>();
builder.Services.AddTransient<IQuery, Query>();
builder.Services.AddTransient<ICommentApplction, CommentApplction>();
builder.Services.AddTransient<ICommetReposetory,CommetReposetory>();


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
