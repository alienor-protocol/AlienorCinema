using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AlienorCinema.Shared.Services;
using AlienorCinema.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the AlienorCinema.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
