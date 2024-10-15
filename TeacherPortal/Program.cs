using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
namespace TeacherPortal
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped<Radzen.DialogService>();
            builder.Services.AddScoped<Radzen.NotificationService>();
            builder.Services.AddScoped<Radzen.ContextMenuService>();
            builder.Services.AddScoped<Radzen.TooltipService>();
            builder.Services.AddScoped<Radzen.ThemeService>(); // Добавляем службу ThemeService



            await builder.Build().RunAsync();
        }
    }
}
