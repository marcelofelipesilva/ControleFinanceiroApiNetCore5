using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleFinanceiroApi.Business.Entities;
using ControleFinanceiroApi.Infra.Data;

namespace ControleFinanceiroApi.Controllers
{
    [Route("api/v1/contapagar")]
    [ApiController]
    public class ContaPagarController : ControllerBase
    {
        private readonly ControleFinanceiroApiDbContext _context;

        public ContaPagarController(ControleFinanceiroApiDbContext context)
        {
            _context = context;
        }

        // GET: api/ContaPagar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContaPagar>>> GetContasPagar()
        {
            return await _context.ContasPagar.ToListAsync();
        }

        // GET: api/ContaPagar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContaPagar>> GetContaPagar(int id)
        {
            var contaPagar = await _context.ContasPagar.FindAsync(id);

            if (contaPagar == null)
            {
                return NotFound();
            }

            return contaPagar;
        }

        // PUT: api/ContaPagar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContaPagar(int id, ContaPagar contaPagar)
        {
            if (id != contaPagar.ContaPagarID)
            {
                return BadRequest();
            }

            _context.Entry(contaPagar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaPagarExists(id))
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

        // POST: api/ContaPagar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContaPagar>> PostContaPagar(ContaPagar contaPagar)
        {
            _context.ContasPagar.Add(contaPagar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContaPagar", new { id = contaPagar.ContaPagarID }, contaPagar);
        }

        // DELETE: api/ContaPagar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContaPagar(int id)
        {
            var contaPagar = await _context.ContasPagar.FindAsync(id);
            if (contaPagar == null)
            {
                return NotFound();
            }

            _context.ContasPagar.Remove(contaPagar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContaPagarExists(int id)
        {
            return _context.ContasPagar.Any(e => e.ContaPagarID == id);
        }
    }
}
