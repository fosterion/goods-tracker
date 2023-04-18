using GoodsTracker.Dto.Models;
using Microsoft.AspNetCore.Authorization;

namespace GoodsTracker.Api;

[HttpGet("manage/add"), AllowAnonymous]
public class CreateEndpoint : Endpoint<CreateRequest, CreateResponse>
{
    private readonly ILogger<CreateEndpoint> _logger;

    public CreateEndpoint(ILogger<CreateEndpoint> logger)
    {
        _logger = logger;
    }

    public override async Task HandleAsync(CreateRequest req, CancellationToken ct)
    {
        await SendAsync(new());
    }
}
