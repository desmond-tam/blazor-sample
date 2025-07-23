using BlazorAppSample;
using BlazorAppSample.Models;
using BlazorAppSample.Models.Options;
using BlazorAppSample.Services;
using BlazorAppSample.Services.Interfaces;
using BlazorBootstrap;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// add security option
builder.Services.Configure<SecurityOption>(options => builder.Configuration.GetSection("Security").Bind(options));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


builder.Services.AddScoped<ITickerService, TickerService>();
builder.Services.AddSingleton<ToastService>();
builder.Services.AddBlazorBootstrap();
builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    options.ProviderOptions.DefaultAccessTokenScopes.Add("email");
});


await builder.Build().RunAsync();
