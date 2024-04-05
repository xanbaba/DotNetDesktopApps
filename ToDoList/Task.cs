using System;

namespace ToDoList;

public class Task
{
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public Priority TaskPriority { get; set; }
    public bool IsUrgent { get; set; }
    public DateTime ExpireDate { get; set; }
    public bool IsDone { get; set; }
    public override string ToString() => Title;
}