using FastEndpoints;
using GoodsTracker.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure(builder.Configuration);
builder.Services.AddFastEndpoints();

var app = builder.Build();

app.UseAuthorization();
app.UseFastEndpoints();

app.MapGet("/", () => "Hello World!");

app.Run();
