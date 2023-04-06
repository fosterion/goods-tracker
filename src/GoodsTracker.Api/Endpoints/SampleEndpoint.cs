using Microsoft.AspNetCore.Authorization;

namespace GoodsTracker.Api;

[HttpGet("test/{id:guid}"), AllowAnonymous]
public class SampleEndpoint : Endpoint<SampleRequest>
{
    private readonly ILogger<SampleEndpoint> _logger;

    public SampleEndpoint(ILogger<SampleEndpoint> logger)
    {
        _logger = logger;
    }

    public override async Task HandleAsync(SampleRequest req, CancellationToken ct)
    {
        _logger.LogDebug("DI test");

        await SendAsync(new
        {
            message = $"Response test. Uid = {req.Id}"
        }, cancellation: ct);
    }
}

public class SampleRequest
{
    public Guid Id { get; init; }
}