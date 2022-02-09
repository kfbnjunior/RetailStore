using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetailStore.Server.Data;
using RetailStore.Shared.Domain;

namespace RetailStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CreatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Creates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetCreates()
        {
            return await _context.Creates.ToListAsync();
        }

        // GET: api/Creates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetCreate(int id)
        {
            var create = await _context.Creates.FindAsync(id);

            if (create == null)
            {
                return NotFound();
            }

            return create;
        }

        // PUT: api/Creates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreate(int id, Order create)
        {
            if (id != create.Id)
            {
                return BadRequest();
            }

            _context.Entry(create).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreateExists(id))
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

        // POST: api/Creates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostCreate(Order create)
        {
            _context.Creates.Add(create);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCreate", new { id = create.Id }, create);
        }

        // DELETE: api/Creates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCreate(int id)
        {
            var create = await _context.Creates.FindAsync(id);
            if (create == null)
            {
                return NotFound();
            }

            _context.Creates.Remove(create);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CreateExists(int id)
        {
            return _context.Creates.Any(e => e.Id == id);
        }
    }
}
