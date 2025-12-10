using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndAPI.Data;
using BackEndAPI.Models;

namespace BackEndAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcessorioModeloController : ControllerBase
    {
        private readonly BackEndAPIContext _context;

        public AcessorioModeloController(BackEndAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AcessorioModelo>>> GetAcessoriosModelos()
        {
            return await _context.Set<AcessorioModelo>()
                .Include(am => am.Acessorio)
                .Include(am => am.Modelo)
                .ToListAsync();
        }

        [HttpGet("{idAcessorio}/{idModelo}")]
        public async Task<ActionResult<AcessorioModelo>> GetAcessorioModelo(int idAcessorio, int idModelo)
        {
            var am = await _context.Set<AcessorioModelo>()
                .Include(x => x.Acessorio)
                .Include(x => x.Modelo)
                .FirstOrDefaultAsync(x => x.IdAcessorio == idAcessorio && x.IdModelo == idModelo);

            if (am == null) return NotFound();
            return am;
        }

        [HttpPost]
        public async Task<ActionResult<AcessorioModelo>> PostAcessorioModelo(AcessorioModelo am)
        {
            _context.Set<AcessorioModelo>().Add(am);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAcessorioModelo), new { idAcessorio = am.IdAcessorio, idModelo = am.IdModelo }, am);
        }

        [HttpPut("{idAcessorio}/{idModelo}")]
        public async Task<IActionResult> PutAcessorioModelo(int idAcessorio, int idModelo, AcessorioModelo am)
        {
            if (idAcessorio != am.IdAcessorio || idModelo != am.IdModelo) return BadRequest();

            _context.Entry(am).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{idAcessorio}/{idModelo}")]
        public async Task<IActionResult> DeleteAcessorioModelo(int idAcessorio, int idModelo)
        {
            var am = await _context.Set<AcessorioModelo>()
                .FirstOrDefaultAsync(x => x.IdAcessorio == idAcessorio && x.IdModelo == idModelo);

            if (am == null) return NotFound();

            _context.Set<AcessorioModelo>().Remove(am);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
