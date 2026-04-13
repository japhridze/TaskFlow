using TaskFlow.Domain.Common;

namespace TaskFlow.Domain.Entities;

public class Workspace : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public Guid OwnerId { get; set; }

    public User Owner { get; set; } = null!;
}