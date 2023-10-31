global using UDI_kodetest.Shared.Models;
global using UDI_kodetest.Shared.Models.Entities;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UDI_kodetest.Client;
using UDI_kodetest.Client.Services.JsonImportService;
using UDI_kodetest.Client.Services.SoknadService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// registrere services
builder.Services.AddScoped<IJsonImportService, JsonImportService>();
builder.Services.AddScoped<ISoknadService, SoknadService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
