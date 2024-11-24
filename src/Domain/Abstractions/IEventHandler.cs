namespace Domain.Abstractions;

/// <summary>
/// Represents the event handler for a specific event.
/// </summary>
/// <typeparam name="TEvent"></typeparam>
public interface IEventHandler<in TEvent>
    where TEvent : IEvent
{
    /// <summary>
    /// Handles the specified event.
    /// </summary>
    /// <param name="event">The event.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The completed task.</returns>
    Task Handle(TEvent @event, CancellationToken cancellationToken = default);
}

/// <summary>
/// Represents the event handler for a specific event.
/// </summary>
public interface IEventHandler
{
    /// <summary>
    /// Handles the specified event.
    /// </summary>
    /// <param name="event">The event.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The completed task.</returns>
    Task Handle(IEvent @event, CancellationToken cancellationToken = default);
}