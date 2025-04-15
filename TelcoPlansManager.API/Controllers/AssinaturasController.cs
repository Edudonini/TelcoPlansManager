using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelcoPlansManager.API.Data;
using TelcoPlansManager.API.Entities;

namespace TelcoPlansManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssinaturasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AssinaturasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Assinaturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assinatura>>> GetAssinaturas()
        {
            return await _context.Assinaturas
                .Include(a => a.Cliente)
                .Include(a => a.Plano)
                .ToListAsync();
        }

        // GET: api/Assinaturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Assinatura>> GetAssinatura(int id)
        {
            var assinatura = await _context.Assinaturas
                .Include(a => a.Cliente)
                .Include(a => a.Plano)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (assinatura == null)
            {
                return NotFound();
            }

            return assinatura;
        }

        // PUT: api/Assinaturas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssinatura(int id, Assinatura assinatura)
        {
            if (id != assinatura.Id)
            {
                return BadRequest();
            }

            _context.Entry(assinatura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssinaturaExists(id))
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

        // POST: api/Assinaturas
        [HttpPost]
        public async Task<ActionResult<Assinatura>> PostAssinatura(Assinatura assinatura)
        {
            _context.Assinaturas.Add(assinatura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssinatura", new { id = assinatura.Id }, assinatura);
        }

        // DELETE: api/Assinaturas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssinatura(int id)
        {
            var assinatura = await _context.Assinaturas.FindAsync(id);
            if (assinatura == null)
            {
                return NotFound();
            }

            _context.Assinaturas.Remove(assinatura);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssinaturaExists(int id)
        {
            return _context.Assinaturas.Any(e => e.Id == id);
        }
    }
} 