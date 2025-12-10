using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndAPI.Data;
using BackEndAPI.Models;

namespace BackEndAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculoAcessorioController : ControllerBase
    {
        private readonly BackEndAPIContext _context;

        public VeiculoAcessorioController(BackEndAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VeiculoAcessorio>>> GetVeiculoAcessorios()
        {
            return await _context.Set<VeiculoAcessorio>()
                .Include(va => va.Veiculo)
                .Include(va => va.Acessorio)
                .ToListAsync();
        }

        [HttpGet("{idVeiculo}/{idAcessorio}")]
        public async Task<ActionResult<VeiculoAcessorio>> GetVeiculoAcessorio(int idVeiculo, int idAcessorio)
        {
            var va = await _context.Set<VeiculoAcessorio>()
                .Include(x => x.Veiculo)
                .Include(x => x.Acessorio)
                .FirstOrDefaultAsync(x => x.IdVeiculo == idVeiculo && x.IdAcessorio == idAcessorio);

            if (va == null) return NotFound();
            return va;
        }

        [HttpPost]
        public async Task<ActionResult<VeiculoAcessorio>> PostVeiculoAcessorio(VeiculoAcessorio va)
        {
            _context.Set<VeiculoAcessorio>().Add(va);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVeiculoAcessorio), new { idVeiculo = va.IdVeiculo, idAcessorio = va.IdAcessorio }, va);
        }

        [HttpPut("{idVeiculo}/{idAcessorio}")]
        public async Task<IActionResult> PutVeiculoAcessorio(int idVeiculo, int idAcessorio, VeiculoAcessorio va)
        {
            if (idVeiculo != va.IdVeiculo || idAcessorio != va.IdAcessorio) return BadRequest();

            _context.Entry(va).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{idVeiculo}/{idAcessorio}")]
        public async Task<IActionResult> DeleteVeiculoAcessorio(int idVeiculo, int idAcessorio)
        {
            var va = await _context.Set<VeiculoAcessorio>()
                .FirstOrDefaultAsync(x => x.IdVeiculo == idVeiculo && x.IdAcessorio == idAcessorio);

            if (va == null) return NotFound();

            _context.Set<VeiculoAcessorio>().Remove(va);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
