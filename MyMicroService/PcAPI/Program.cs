using Microsoft.EntityFrameworkCore;
using Pc.Business.Abstract;
using Pc.Business.Concrete;
using Pc.DataAccess.Abstract;
using Pc.DataAccess.Concrete;
using Pc.DataAccess.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<ILaptopDal, LaptopDal>();
builder.Services.AddScoped<ILaptopService, LaptopManager>();
//builder.Services.AddDbContext<MicroPcServiceDbContext>(
//        options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
