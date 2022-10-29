namespace Domain.Entities;

public class TodoItem
{
    public long Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public State State { get; set; }
    public PriorityLevel Priority { get; set; }
    public DateTime? Reminder { get; set; }
    public DateTime? DueDate { get; set; }
}