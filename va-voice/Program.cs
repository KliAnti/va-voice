using va_voice.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddScoped<VoiceGrpcService>();

var app = builder.Build();

app.MapGrpcService<VoiceGrpcService>();

app.Run();
