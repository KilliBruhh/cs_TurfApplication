using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_2._0.Models;

namespace WebApi_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurfsController : ControllerBase
    {
        private readonly TurfContext _context;

        public TurfsController(TurfContext context)
        {
            _context = context;
        }

        // GET: api/Turfs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turf>>> GetTodoItems()
        {
          if (_context.TodoItems == null)
          {
              return NotFound();
          }
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/Turfs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Turf>> GetTurf(long id)
        {
          if (_context.TodoItems == null)
          {
              return NotFound();
          }
            var turf = await _context.TodoItems.FindAsync(id);

            if (turf == null)
            {
                return NotFound();
            }

            return turf;
        }

        // PUT: api/Turfs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurf(long id, Turf turf)
        {
            if (id != turf.Id)
            {
                return BadRequest();
            }

            _context.Entry(turf).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TurfExists(id))
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

        // POST: api/Turfs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Turf>> PostTurf(Turf turf)
        {
          if (_context.TodoItems == null)
          {
              return Problem("Entity set 'TurfContext.TodoItems'  is null.");
          }
            _context.TodoItems.Add(turf);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTurf", new { id = turf.Id }, turf);
        }

        // DELETE: api/Turfs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurf(long id)
        {
            if (_context.TodoItems == null)
            {
                return NotFound();
            }
            var turf = await _context.TodoItems.FindAsync(id);
            if (turf == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(turf);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TurfExists(long id)
        {
            return (_context.TodoItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
