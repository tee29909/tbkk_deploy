using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailOTsController : ControllerBase
    {
        private readonly tbkkdbContext _context;

        public DetailOTsController(tbkkdbContext context)
        {
            _context = context;
        }

        // GET: api/DetailOTs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetailOT>>> GetDetailOT()
        {
            return await _context.DetailOT.ToListAsync();
        }

        // GET: api/DetailOTs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailOT>> GetDetailOT(int id)
        {
            var detailOT = await _context.DetailOT.FindAsync(id);

            if (detailOT == null)
            {
                return NotFound();
            }

            return detailOT;
        }

        // PUT: api/DetailOTs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetailOT(int id, DetailOT detailOT)
        {
            if (id != detailOT.DetailOTID)
            {
                return BadRequest();
            }

            _context.Entry(detailOT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetailOTExists(id))
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

        // POST: api/DetailOTs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DetailOT>> PostDetailOT(DetailOT detailOT)
        {
            _context.DetailOT.Add(detailOT);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetailOT", new { id = detailOT.DetailOTID }, detailOT);
        }

        // DELETE: api/DetailOTs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DetailOT>> DeleteDetailOT(int id)
        {
            var detailOT = await _context.DetailOT.FindAsync(id);
            if (detailOT == null)
            {
                return NotFound();
            }

            _context.DetailOT.Remove(detailOT);
            await _context.SaveChangesAsync();

            return detailOT;
        }

        private bool DetailOTExists(int id)
        {
            return _context.DetailOT.Any(e => e.DetailOTID == id);
        }
    }
}
