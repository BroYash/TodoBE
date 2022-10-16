using TodoBE.Application.TodoLists.Queries.ExportTodos;

namespace TodoBE.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
