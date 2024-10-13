using Microsoft.EntityFrameworkCore;
using PBBG;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


var app =
    WebApplication.CreateBuilder(args)
        .ConfigureServices()
        .ConfigurePipeline();

// using (var scope = app.Services.CreateScope())
// {
//     await using var db = await scope.ServiceProvider.GetRequiredService<IDbContextFactory<YoutubarrContext>>()
//         .CreateDbContextAsync();
//     
//     await db.Database.MigrateAsync();
// }

await app.RunAsync();