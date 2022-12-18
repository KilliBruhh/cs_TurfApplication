using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPi.Models;

namespace WebAPi.Controllers
{
    [Route("api/[turfsController]")]
    [ApiController]
    public class turfsController : ControllerBase
    {
        private readonly turfContext _context;

        public turfsController(turfContext context)
        {
            _context = context;
        }

        public turfsController()
        {
        }

        // GET: api/turfs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<turf>>> GetTurfItems()
        {
            if (_context.TurfItems == null)
            {
                return NotFound();
            }
            return await _context.TurfItems.ToListAsync();
        }

        // GET: api/turfs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<turf>> Getturf(long id)
        {
            if (_context.TurfItems == null)
            {
                return NotFound();
            }
            var turf = await _context.TurfItems.FindAsync(id);

            if (turf == null)
            {
                return NotFound();
            }

            return turf;
        }

        // PUT: api/turfs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putturf(long id, turf turf)
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
                if (!turfExists(id))
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

        // POST: api/turfs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<turf>> Postturf(turf turf)
        {
            if (_context.TurfItems == null)
            {
                return Problem("Entity set 'turfContext.TurfItems'  is null.");
            }
            _context.TurfItems.Add(turf);
            await _context.SaveChangesAsync();

            // Error: --> chnage GetTurf to GetTurfItems
            return CreatedAtAction(nameof(Getturf), new { id = turf.Id }, turf);
        }


        // DELETE: api/turfs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteturf(long id)
        {
            if (_context.TurfItems == null)
            {
                return NotFound();
            }
            var turf = await _context.TurfItems.FindAsync(id);
            if (turf == null)
            {
                return NotFound();
            }

            _context.TurfItems.Remove(turf);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool turfExists(long id)
        {
            return (_context.TurfItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}