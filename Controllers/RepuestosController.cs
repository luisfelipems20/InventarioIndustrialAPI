using InventarioIndustrialAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventarioIndustrialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepuestosController : ControllerBase
    {
        private readonly InventarioContext _context;

        public RepuestosController(InventarioContext context)
        {
            _context = context;
        }

        // GET: api/Repuestos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Repuesto>>> GetRepuestos()
        {
            return await _context.Repuestos.ToListAsync();
        }

        // GET: api/Repuestos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Repuesto>> GetRepuesto(int id)
        {
            var repuesto = await _context.Repuestos.FindAsync(id);
            if (repuesto == null) return NotFound();
            return repuesto;
        }

        // POST: api/Repuestos
        [HttpPost]
        public async Task<ActionResult<Repuesto>> PostRepuesto(Repuesto repuesto)
        {
            _context.Repuestos.Add(repuesto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetRepuesto), new { id = repuesto.Id }, repuesto);
        }

        // PUT: api/Repuestos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRepuesto(int id, Repuesto repuesto)
        {
            if (id != repuesto.Id) return BadRequest();
            _context.Entry(repuesto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/Repuestos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRepuesto(int id)
        {
            var repuesto = await _context.Repuestos.FindAsync(id);
            if (repuesto == null) return NotFound();
            _context.Repuestos.Remove(repuesto);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}