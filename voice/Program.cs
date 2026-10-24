using voice.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((_, loggerConfiguration) =>
    loggerConfiguration.WriteTo.Console());

builder.Services.AddGrpc();
builder.Services.AddScoped<VoiceGrpcService>();

var app = builder.Build();

app.MapGrpcService<VoiceGrpcService>();

app.Run();
