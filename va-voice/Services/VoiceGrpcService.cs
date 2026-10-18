using Grpc.Core;

namespace va_voice.Services;

public sealed class VoiceGrpcService(ILogger<VoiceGrpcService> logger) : Voice.VoiceBase
{
    public override Task<PongResponse> Ping(PingRequest request, ServerCallContext context)
    {
        logger.LogInformation("Received ping: {Message}", request.Message);

        return Task.FromResult(new PongResponse { Message = "Pong" });
    }
}
