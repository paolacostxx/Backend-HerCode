using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndAPI.Data;
using BackEndAPI.Models;

namespace BackEndAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModeloController : ControllerBase
    {
        private readonly BackEndAPIContext _context;

        public ModeloController(BackEndAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modelo>>> GetModelos()
        {
            return await _context.Modelo
                .Include(m => m.Veiculos)
                .Include(m => m.AcessoriosModelos)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Modelo>> GetModelo(int id)
        {
            var modelo = await _context.Modelo
                .Include(m => m.Veiculos)
                .Include(m => m.AcessoriosModelos)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (modelo == null) return NotFound();
            return modelo;
        }

        [HttpPost]
        public async Task<ActionResult<Modelo>> PostModelo(Modelo modelo)
        {
            _context.Modelo.Add(modelo);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetModelo), new { id = modelo.Id }, modelo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutModelo(int id, Modelo modelo)
        {
            if (id != modelo.Id) return BadRequest();

            _context.Entry(modelo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModelo(int id)
        {
            var modelo = await _context.Modelo.FindAsync(id);
            if (modelo == null) return NotFound();

            _context.Modelo.Remove(modelo);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
