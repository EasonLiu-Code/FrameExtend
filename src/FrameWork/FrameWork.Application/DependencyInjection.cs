using Microsoft.Extensions.DependencyInjection;

namespace FrameWork.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}