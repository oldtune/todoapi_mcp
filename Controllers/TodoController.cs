
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    readonly ILogger<TodoController> _logger;
    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTodos()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTodo()
    {
        return Ok();
    }

    [HttpPost("{id}")]
    public async Task<IActionResult> MarkTodoAsCompleted(int id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodo(int id)
    {
        return Ok();
    }
}
