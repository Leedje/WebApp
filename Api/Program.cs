using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            await builder.Build().RunAsync();

            // Configure HttpClient to send requests to your Arduino
            builder.Services.AddScoped(sp => new HttpClient
            {
                //Voer IP Adres in
                BaseAddress = new Uri("http://145.93.232.26/") // Replace with your actual Arduino IP
            });

    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
    })
    .Build();

host.Run();
