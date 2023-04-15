using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lumberjack_Typing_Adventure_API;
using Lumberjack_Typing_Adventure_API.Entities;

namespace Lumberjack_Typing_Adventure_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighScoresController : ControllerBase
    {
        private readonly ScoreboardContext _context;

        public HighScoresController()
        {
            _context = new ScoreboardContext();
        }

        // GET: api/HighScores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HighScore>>> GetHighScores()
        {
          if (_context.HighScores == null)
          {
              return NotFound();
          }
            return await _context.HighScores.ToListAsync();
        }

        // GET: api/HighScores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HighScore>> GetHighScore(Guid id)
        {
          if (_context.HighScores == null)
          {
              return NotFound();
          }
            var highScore = await _context.HighScores.FindAsync(id);

            if (highScore == null)
            {
                return NotFound();
            }

            return highScore;
        }

        // PUT: api/HighScores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHighScore(Guid id, HighScore highScore)
        {
            if (id != highScore.id)
            {
                return BadRequest();
            }

            _context.Entry(highScore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HighScoreExists(id))
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

        // POST: api/HighScores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HighScore>> PostHighScore(HighScore highScore)
        {
          if (_context.HighScores == null)
          {
              return Problem("Entity set 'ScoreboardContext.HighScores'  is null.");
          }
            _context.HighScores.Add(highScore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHighScore", new { id = highScore.id }, highScore);
        }

        // DELETE: api/HighScores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHighScore(Guid id)
        {
            if (_context.HighScores == null)
            {
                return NotFound();
            }
            var highScore = await _context.HighScores.FindAsync(id);
            if (highScore == null)
            {
                return NotFound();
            }

            _context.HighScores.Remove(highScore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HighScoreExists(Guid id)
        {
            return (_context.HighScores?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
