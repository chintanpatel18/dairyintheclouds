using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DairyInTheClouds.Models;
using System.Threading.Tasks;

public class JournalsController : Controller
{
    private readonly ApplicationDbContext _context;

    public JournalsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [Authorize]
    public async Task<IActionResult> Index()
    {
        var journals = await _context.Journals.ToListAsync();
        return View(journals);
    }

    // Other CRUD actions
}
