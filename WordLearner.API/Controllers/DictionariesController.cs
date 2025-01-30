using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WordLearner.Infra;

// Controllers/DictionariesController.cs
[ApiController]
[Route("api/dictionaries")]
[Authorize]
public class DictionariesController : ControllerBase
{
    private readonly AppDbContext _context;
    public DictionariesController(AppDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<List<DictionaryDto>>> GetDictionaries()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Получаем ID текущего пользователя
        var dictionaries = await _context.Dictionaries
            .Where(d => d.UserId == userId)
            .Select(d => new DictionaryDto(d.Id, d.Name))
            .ToListAsync();

        return Ok(dictionaries);
    }

    public record DictionaryDto(int Id, string Name);
}
