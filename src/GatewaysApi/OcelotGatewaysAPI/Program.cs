using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOcelot().AddCacheManager(settings => settings.WithDictionaryHandle());

builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
builder.Logging.AddConsole();
builder.Logging.AddDebug();

var app = builder.Build();
IWebHostEnvironment environment = app.Environment;
builder.Configuration.AddJsonFile($"ocelot.{environment.EnvironmentName}.json", false, true);
await app.UseOcelot();
app.MapGet("/", () => "Hello World!");
app.Run();
