using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndAPI.Data;
using BackEndAPI.Models;

namespace BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaJuridicaController : ControllerBase
    {
        private readonly BackEndAPIContext _context;

        public PessoaJuridicaController(BackEndAPIContext context)
        {
            _context = context;
        }

        // GET: api/PessoaJuridica
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaJuridica>>> GetPessoaJuridica()
        {
            return await _context.PessoaJuridica.ToListAsync();
        }

        // GET: api/PessoaJuridica/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PessoaJuridica>> GetPessoaJuridica(int id)
        {
            var pessoaJuridica = await _context.PessoaJuridica.FindAsync(id);

            if (pessoaJuridica == null)
            {
                return NotFound();
            }

            return pessoaJuridica;
        }

        // PUT: api/PessoaJuridica/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoaJuridica(int id, PessoaJuridica pessoaJuridica)
        {
            if (id != pessoaJuridica.Id)
            {
                return BadRequest();
            }

            _context.Entry(pessoaJuridica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaJuridicaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PessoaJuridica
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PessoaJuridica>> PostPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            _context.PessoaJuridica.Add(pessoaJuridica);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPessoaJuridica", new { id = pessoaJuridica.Id }, pessoaJuridica);
        }

        // DELETE: api/PessoaJuridica/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePessoaJuridica(int id)
        {
            var pessoaJuridica = await _context.PessoaJuridica.FindAsync(id);
            if (pessoaJuridica == null)
            {
                return NotFound();
            }

            _context.PessoaJuridica.Remove(pessoaJuridica);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PessoaJuridicaExists(int id)
        {
            return _context.PessoaJuridica.Any(e => e.Id == id);
        }
    }
}
