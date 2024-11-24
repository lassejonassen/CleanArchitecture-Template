namespace Abstractions;

public interface IUserContext
{
    string? UserId { get; }
    string? UserName { get; }
    string? Initials { get; }
    string? Email { get; }
    string? Token { get; }
    string[] Permissions { get; }
    string[] Roles { get; }
}