using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk
{
    public class EditModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public EditModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DetailCarQueue DetailCarQueue { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DetailCarQueue = await _context.DetailCarQueue
                .Include(d => d.CarQueue)
                .Include(d => d.Employee).FirstOrDefaultAsync(m => m.DetailCarQueueID == id);

            if (DetailCarQueue == null)
            {
                return NotFound();
            }
           ViewData["DetailCarQueue_CarQueueID"] = new SelectList(_context.CarQueue, "CarQueueID", "CarQueueID");
           ViewData["DetailCarQueue_EmployeeID"] = new SelectList(_context.Employee, "EmployeeID", "EmployeeID");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DetailCarQueue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetailCarQueueExists(DetailCarQueue.DetailCarQueueID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DetailCarQueueExists(int id)
        {
            return _context.DetailCarQueue.Any(e => e.DetailCarQueueID == id);
        }
    }
}
