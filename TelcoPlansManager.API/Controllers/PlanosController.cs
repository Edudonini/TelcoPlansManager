using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelcoPlansManager.API.Data;
using TelcoPlansManager.API.Entities;

namespace TelcoPlansManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlanosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Planos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Plano>>> GetPlanos()
        {
            return await _context.Planos
                .Include(p => p.Clientes)
                .Include(p => p.Assinaturas)
                .ToListAsync();
        }

        // GET: api/Planos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Plano>> GetPlano(int id)
        {
            var plano = await _context.Planos
                .Include(p => p.Clientes)
                .Include(p => p.Assinaturas)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (plano == null)
            {
                return NotFound();
            }

            return plano;
        }

        // PUT: api/Planos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlano(int id, Plano plano)
        {
            if (id != plano.Id)
            {
                return BadRequest();
            }

            _context.Entry(plano).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanoExists(id))
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

        // POST: api/Planos
        [HttpPost]
        public async Task<ActionResult<Plano>> PostPlano(Plano plano)
        {
            _context.Planos.Add(plano);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlano", new { id = plano.Id }, plano);
        }

        // DELETE: api/Planos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlano(int id)
        {
            var plano = await _context.Planos.FindAsync(id);
            if (plano == null)
            {
                return NotFound();
            }

            _context.Planos.Remove(plano);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanoExists(int id)
        {
            return _context.Planos.Any(e => e.Id == id);
        }
    }
} 