var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
var settings = builder.Configuration.GetSection("Settings").Get<Settings>();

// Add http client "MyClient"

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
