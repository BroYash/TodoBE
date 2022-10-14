namespace Domain.Events;

public class TodoItemDoneEvent
{
    public TodoItemDoneEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}