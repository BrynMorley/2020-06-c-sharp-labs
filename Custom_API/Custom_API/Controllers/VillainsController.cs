using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Custom_API.Models;

namespace Custom_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillainsController : ControllerBase
    {
        private readonly ComicDBContext _context;

        public VillainsController(ComicDBContext context)
        {
            _context = context;
        }

        // GET: api/Villains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Villains>>> GetVillains()
        {
            return await _context.Villains.ToListAsync();
        }

        // GET: api/Villains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Villains>> GetVillains(int id)
        {
            var villains = await _context.Villains.FindAsync(id);

            if (villains == null)
            {
                return NotFound();
            }

            return villains;
        }

        // PUT: api/Villains/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVillains(int id, Villains villains)
        {
            if (id != villains.VillainId)
            {
                return BadRequest();
            }

            _context.Entry(villains).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VillainsExists(id))
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

        // POST: api/Villains
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Villains>> PostVillains(Villains villains)
        {
            _context.Villains.Add(villains);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVillains", new { id = villains.VillainId }, villains);
        }

        // DELETE: api/Villains/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Villains>> DeleteVillains(int id)
        {
            var villains = await _context.Villains.FindAsync(id);
            if (villains == null)
            {
                return NotFound();
            }

            _context.Villains.Remove(villains);
            await _context.SaveChangesAsync();

            return villains;
        }

        private bool VillainsExists(int id)
        {
            return _context.Villains.Any(e => e.VillainId == id);
        }
    }
}
