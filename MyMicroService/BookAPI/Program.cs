using Book.Business.Abstract;
using Book.Business.Concrete;
using Book.DataAccess.Abstract;
using Book.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IBookDal, BookDal>();
builder.Services.AddScoped<IBookService, BookManager>();

//builder.Services.AddDbContext<BooksDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PortalDB")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
