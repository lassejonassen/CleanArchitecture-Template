using Application.Abstractions.Services;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Services;

public sealed class CorrelationIdService(HttpContextAccessor httpContextAccessor) 
    : ICorrelationIdService
{
    private const string HeaderName = "x-correlation-id";

    private string _correlationId = Guid.NewGuid().ToString();

    public string GetCorrelationId()
    {
        string? headerValue = httpContextAccessor.HttpContext!.Request.Headers[HeaderName].ToString();

        if (string.IsNullOrWhiteSpace(headerValue))
        {
            return _correlationId;
        }

        return headerValue;
    }

    public void SetCorrelationId(string correlationId)
        => _correlationId = correlationId;
}