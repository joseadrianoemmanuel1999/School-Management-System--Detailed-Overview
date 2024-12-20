﻿using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
namespace School.Application.Common.Behaviors;
internal class PerformanceBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : MediatR.IRequest<TResponse>

{
    private readonly Stopwatch _timer;
    private readonly ILogger<TRequest> _logger;

    public PerformanceBehavior(
        ILogger<TRequest> logger)
    {
        _timer = new Stopwatch();
        _logger = logger;
    }
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _timer.Start();
        var response = await next();
        _timer.Stop();

        var elapsedMilliseconds = _timer.ElapsedMilliseconds;
        if (elapsedMilliseconds <= 500) return response;

        var requestName = typeof(TRequest).Name;
        _logger.LogWarning("School Long Running Request: {Name} ({ElapsedMilliseconds} milliseconds) {@Request}",
            requestName, elapsedMilliseconds, request);
        return response;
    }
}


