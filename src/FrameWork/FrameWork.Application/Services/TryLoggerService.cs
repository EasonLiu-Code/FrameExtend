using FrameWork.Application.IServices;
using Microsoft.Extensions.Logging;

namespace FrameWork.Application.Services;

public class TryLoggerService(ILogger<TryLoggerService> logger):ITryLoggerService
{
    public async Task SendLoggerAsync()
    {
        logger.LogInformation($"send logger{typeof(TryLoggerService)}");
    }
}