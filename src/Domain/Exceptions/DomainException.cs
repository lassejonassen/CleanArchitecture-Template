using Domain.Primitives;

namespace Domain.Exceptions;

/// <summary>
/// Represents an exception that occurs in the domain.
/// </summary>
public class DomainException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainException"/> class.
    /// </summary>
    /// <param name="error">The erro containing the information about what happended.</param>
    public DomainException(Error error)
        : base(error.Description)
        => Error = error;
    
    /// <summary>
    /// Gets the error.
    /// </summary>
    public Error Error { get; }
}