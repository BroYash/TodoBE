using TodoBE.Application.Common.Mappings;
using TodoBE.Domain.Entities;

namespace TodoBE.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
