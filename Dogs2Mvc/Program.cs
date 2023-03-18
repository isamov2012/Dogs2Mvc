var builder = WebApplication.CreateBuilder(args);

// Stöd för controllers och views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Stöd för att mappa HTTP-anrop till våra controllers
app.UseRouting();

// Stöd för Route-attribut på våra Action-metoder
app.UseEndpoints(o => o.MapControllers());

app.Run();
