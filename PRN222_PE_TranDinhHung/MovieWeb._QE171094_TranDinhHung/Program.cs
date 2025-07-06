var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<MovieWeb_Repo.IMovieRepo, MovieWeb_Repo.MovieRepo>();
builder.Services.AddScoped<MovieWeb_Repo.IDirectorRepo, MovieWeb_Repo.DirectorRepo>();

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

// Redirect root URL to /Movies/Director_Movie
app.MapGet("/", context => {
    context.Response.Redirect("/Movies/Director_Movie");
    return Task.CompletedTask;
});

app.Run();
