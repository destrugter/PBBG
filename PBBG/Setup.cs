using Microsoft.FluentUI.AspNetCore.Components;
using PBBG.Components;
using PBBG.Shared;

namespace PBBG;

public static class Setup
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddRazorComponents().AddInteractiveServerComponents();
        builder.Services.AddHttpClient();
        builder.Services.AddSingleton<Microsoft.FluentUI.AspNetCore.Components.LibraryConfiguration>();
        builder.Services.AddFluentUIComponents();
        builder.Services.AddSingleton<NavProvider>();
        builder.Services.AddDataGridEntityFrameworkAdapter();

        //builder.Services.AddYoutubarrServices();
        // builder.Services.AddHostedService<HealthCheckRefresher>();
        // builder.Services.AddApollo(
        //     x => x.UseNats()
        //         .WithEndpoints(
        //             endpoints =>
        //             {
        //                 endpoints.AddEndpoint<BeaconEndpoint>();
        //                 endpoints.AddEndpoint<HealthCheckEndpoint>();
        //             })
        // );
        // builder.Services.AddSingleton<IStateObserver, StateObserver>();
        // builder.Services.AddScoped<ITooltipService, TooltipService>();

        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        return app;
    }
}