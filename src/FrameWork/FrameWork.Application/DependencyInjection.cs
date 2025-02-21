using FrameWork.Application.IServices;
using FrameWork.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FrameWork.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<ITryLoggerService, TryLoggerService>();
        return services;
    }
}