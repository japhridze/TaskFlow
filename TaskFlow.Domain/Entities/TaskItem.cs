using TaskFlow.Domain.Common;

namespace TaskFlow.Domain.Entities;

public class TaskItem : BaseEntity
{
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid ProjectId { get; set; }

    public Project Project { get; set; } = null!;

    public Guid? AssigneeId { get; set; }

    public User? Assignee { get; set; }

    public string Status { get; set; } = "ToDo";

    public string Priority { get; set; } = "Medium";

    public DateTime? DueDate { get; set; }
}