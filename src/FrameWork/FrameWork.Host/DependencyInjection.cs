using FrameWork.Persistence;
using OpenTelemetry.Resources;

namespace FrameWork;

public static class DependencyInjection
{
    public static IServiceCollection AddOpenTelemetry(this IServiceCollection services)
    {
        return services;
    }
}