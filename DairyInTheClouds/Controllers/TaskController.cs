// TasksController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class TasksController : Controller
{
    private readonly ApplicationDbContext _context;

    public TasksController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Tasks
    public async Task<IActionResult> Index()
    {
        var tasks = await _context.Tasks.ToListAsync();
        return View(tasks);
    }

    // Other CRUD actions
}