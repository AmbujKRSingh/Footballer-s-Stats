using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayerAPI.Models;

namespace Footballers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerDetailController : ControllerBase
    {
        private readonly PlayerDetailContext _context;

        public PlayerDetailController(PlayerDetailContext context)
        {
            _context = context;
        }

        // GET: api/PlayerDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerDetail>>> GetPlayerDetails()
        {
            return await _context.PlayerDetails.ToListAsync();
        }

        // GET: api/PlayerDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerDetail>> GetPlayerDetail(int id)
        {
            var playerDetail = await _context.PlayerDetails.FindAsync(id);

            if (playerDetail == null)
            {
                return NotFound();
            }

            return playerDetail;
        }

        // PUT: api/PlayerDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayerDetail(int id, PlayerDetail playerDetail)
        {
            if (id != playerDetail.PlayerDetailId)
            {
                return BadRequest();
            }

            _context.Entry(playerDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerDetailExists(id))
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

        // POST: api/PlayerDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlayerDetail>> PostPlayerDetail(PlayerDetail playerDetail)
        {
            _context.PlayerDetails.Add(playerDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayerDetail", new { id = playerDetail.PlayerDetailId }, playerDetail);
        }

        // DELETE: api/PlayerDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerDetail(int id)
        {
            var playerDetail = await _context.PlayerDetails.FindAsync(id);
            if (playerDetail == null)
            {
                return NotFound();
            }

            _context.PlayerDetails.Remove(playerDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerDetailExists(int id)
        {
            return _context.PlayerDetails.Any(e => e.PlayerDetailId == id);
        }
    }
}
