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
    public class HeroesController : ControllerBase
    {
        private readonly ComicDBContext _context;

        public HeroesController(ComicDBContext context)
        {
            _context = context;
        }

        // GET: api/Heroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Heroes>>> GetHeroes()
        {
            return await _context.Heroes.ToListAsync();
        }

        // GET: api/Heroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Heroes>> GetHeroes(int id)
        {
            var heroes = await _context.Heroes.FindAsync(id);

            if (heroes == null)
            {
                return NotFound();
            }

            return heroes;
        }

        // PUT: api/Heroes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHeroes(int id, Heroes heroes)
        {
            if (id != heroes.HeroId)
            {
                return BadRequest();
            }

            _context.Entry(heroes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroesExists(id))
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

        // POST: api/Heroes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Heroes>> PostHeroes(Heroes heroes)
        {
            _context.Heroes.Add(heroes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHeroes", new { id = heroes.HeroId }, heroes);
        }

        // DELETE: api/Heroes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Heroes>> DeleteHeroes(int id)
        {
            var heroes = await _context.Heroes.FindAsync(id);
            if (heroes == null)
            {
                return NotFound();
            }

            _context.Heroes.Remove(heroes);
            await _context.SaveChangesAsync();

            return heroes;
        }

        private bool HeroesExists(int id)
        {
            return _context.Heroes.Any(e => e.HeroId == id);
        }
    }
}
