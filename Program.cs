using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Webcam_Robot_WebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            await builder.Build().RunAsync();

            // Configure HttpClient to send requests to your Arduino
            builder.Services.AddScoped(sp => new HttpClient
            {
                //Voer IP Adres in
                BaseAddress = new Uri("http://145.93.232.26/") // Replace with your actual Arduino IP
            });

        }

    }
}
