using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
builder.Logging.AddConsole();
builder.Logging.AddDebug();
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
await app.UseOcelot();
app.Run();
