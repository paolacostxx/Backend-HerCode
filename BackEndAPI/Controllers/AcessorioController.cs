using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndAPI.Data;
using BackEndAPI.Models;

namespace BackEndAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcessorioController : ControllerBase
    {
        private readonly BackEndAPIContext _context;

        public AcessorioController(BackEndAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Acessorio>>> GetAcessorios()
        {
            return await _context.Acessorio
                .Include(a => a.VeiculosAcessorios)
                .Include(a => a.ModelosAcessorios)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Acessorio>> GetAcessorio(int id)
        {
            var acessorio = await _context.Acessorio
                .Include(a => a.VeiculosAcessorios)
                .Include(a => a.ModelosAcessorios)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (acessorio == null) return NotFound();
            return acessorio;
        }

        [HttpPost]
        public async Task<ActionResult<Acessorio>> PostAcessorio(Acessorio acessorio)
        {
            _context.Acessorio.Add(acessorio);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAcessorio), new { id = acessorio.Id }, acessorio);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcessorio(int id, Acessorio acessorio)
        {
            if (id != acessorio.Id) return BadRequest();

            _context.Entry(acessorio).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAcessorio(int id)
        {
            var acessorio = await _context.Acessorio.FindAsync(id);
            if (acessorio == null) return NotFound();

            _context.Acessorio.Remove(acessorio);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
