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
    public class VeiculoController : ControllerBase
    {
        private readonly BackEndAPIContext _context;

        public VeiculoController(BackEndAPIContext context)
        {
            _context = context;
        }

        // GET: api/Veiculo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetVeiculo()
        {
            return await _context.Veiculo.ToListAsync();
        }

        // GET: api/Veiculo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Veiculo>> GetVeiculo(int id)
        {
            var veiculo = await _context.Veiculo.FindAsync(id);

            if (veiculo == null)
            {
                return NotFound();
            }

            return veiculo;
        }

        // PUT: api/Veiculo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVeiculo(int id, Veiculo veiculo)
        {
            if (id != veiculo.Id)
            {
                return BadRequest();
            }

            _context.Entry(veiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculoExists(id))
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

       [HttpPost]
    public async Task<ActionResult<Veiculo>> PostVeiculo(VeiculoDto dto)
    {
        // Verifica se existe o pedido relacionado
        var pedido = await _context.Pedido.FindAsync(dto.PedidoId);
        if (pedido == null)
        {
            return NotFound($"Pedido com ID {dto.PedidoId} não encontrado.");
        }

        var veiculo = new Veiculo
        {
            PedidoId = dto.PedidoId,
            IdChassi = dto.IdChassi,
            NomeVeiculo = dto.NomeVeiculo,
            ModeloVeiculo = dto.ModeloVeiculo,
            Versao = dto.Versao,
            Ano = dto.Ano,
            Cor = dto.Cor
        };

        _context.Veiculo.Add(veiculo);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetVeiculo", new { id = veiculo.Id }, veiculo);
    }


        // DELETE: api/Veiculo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVeiculo(int id)
        {
            var veiculo = await _context.Veiculo.FindAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            _context.Veiculo.Remove(veiculo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VeiculoExists(int id)
        {
            return _context.Veiculo.Any(e => e.Id == id);
        }
    }
}
