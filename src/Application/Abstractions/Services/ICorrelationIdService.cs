namespace Application.Abstractions.Services;

public interface ICorrelationIdService
{
    string GetCorrelationId();
    void SetCorrelationId(string correlationId);
}