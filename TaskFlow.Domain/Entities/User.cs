using TaskFlow.Domain.Common;

namespace TaskFlow.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool IsActive { get; set; } = true;
}