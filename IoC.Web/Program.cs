using IoC.Web.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ISingletonDateService,DateService>();
builder.Services.AddScoped<IScopeDateService,DateService>(); //Bir requestte 5 constructorda varsa 1 kere oluþturulur hepsinde o kullanýlýr.
                                                             // Yeni requestte tekrar olusturulur.

builder.Services.AddTransient<ITransientDateService,DateService>(); //Bir requestte kaç kez geçiyorsa o kadar nesne örneði oluþtur.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
