using Domain.Entities;
using Domain.Enums;

namespace Infrastructure.Persistence;

public class Seed
{
    public static async void SeedData(DataContext context)
    {
        if (context.TodoItems.Any()) return;
        
        var todoitems = new List<TodoItem>
        {
            new TodoItem {
                Title = "Finish ignite challenge",
                Description = "Complete the ignite challenge",
                Priority = PriorityLevel.High,
                State = State.InProgress,
                Reminder = DateTime.Now.AddDays(1).ToUniversalTime(),
                DueDate = DateTime.Now.AddDays(2).ToUniversalTime(),
            },
            new TodoItem {
                Title = "Walk the dog",
                Description = "Take the dog for a walk",
                Priority = PriorityLevel.Medium,
                State = State.Scheduled,
                Reminder = DateTime.Now.AddDays(1).ToUniversalTime(),
                DueDate = DateTime.Now.AddDays(2).ToUniversalTime(),
            },
            new TodoItem {
                Title = "Buy groceries",
                Description = "Buy groceries for the week",
                Priority = PriorityLevel.Low,
                State = State.Todo,
                Reminder = DateTime.Now.AddDays(1).ToUniversalTime(),
                DueDate = DateTime.Now.AddDays(2).ToUniversalTime(),
            },
            new TodoItem {
                Title = "Clean the house",
                Description = "Clean the house",
                Priority = PriorityLevel.High,
                State = State.Done,
                Reminder = DateTime.Now.AddDays(1).ToUniversalTime(),
                DueDate = DateTime.Now.AddDays(2).ToUniversalTime(),
            },
        };

        await context.TodoItems.AddRangeAsync(todoitems);
        await context.SaveChangesAsync();
    }
}