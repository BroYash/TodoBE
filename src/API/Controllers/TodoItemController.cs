using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// local imports
using Domain.Entities;
using Infrastructure.Persistence;

namespace API.Controllers;

public class TodoItemController : BaseApiController
{
    private readonly DataContext _context;

    public TodoItemController(DataContext context)
    {
        _context = context;
    }

    // GET: api/TodoItem
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
    {
        return await _context.TodoItems.ToListAsync();
    }

    // GET: api/TodoItem/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);

        if (todoItem == null)
        {
            return NotFound();
        }

        return todoItem;
    }
}