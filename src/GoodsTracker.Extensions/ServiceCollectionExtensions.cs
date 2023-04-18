using FluentValidation;
using FluentValidation.AspNetCore;
using GoodsTracker.Core;
using GoodsTracker.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoodsTracker.Extensions;

public static class ServiceCollectionExtensions
{
    public static void Configure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDb(configuration);
        services.AddValidation();
    }

    private static void AddDb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TrackerContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("Postgres"))
                .UseSnakeCaseNamingConvention();
        });
    }

    private static void AddValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<Class1>()
            .AddFluentValidationAutoValidation();
    }
}
