namespace Domain.Entities;

public class TodoItem : BaseAuditableEntity
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public State State { get; set; }
    public Location? Location { get; set; }
    
}