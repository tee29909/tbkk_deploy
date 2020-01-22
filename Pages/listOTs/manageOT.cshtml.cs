using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk.Pages.listOTs
{
    public class manageOTModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public manageOTModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }
        public Employee Employee { get; set; }
        public IList<OT> OT { get;set; }
        [BindProperty]
        public OT OTs { get; set; }

        

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            
            OT = await _context.OT.ToListAsync();
            Employee = await _context.Employee
               .Include(e => e.Company)
               .Include(e => e.Department)
               .Include(e => e.EmployeeType)
               .Include(e => e.Location)
               .Include(e => e.Position).FirstOrDefaultAsync(m => m.EmployeeID == id);

           

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }





        public async Task<IActionResult> OnPostAsync(int? id,int? Did)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            OTs = await _context.OT.FirstOrDefaultAsync(o => o.OTID == Did);
            OTs.TypStatus = "Manage Car";
            _context.Attach(OTs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OTExists(OTs.OTID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }



            return RedirectToPage("./../listOTs/ConfirmShuttle", new { id = id ,Did = Did });
        }

        private bool OTExists(int id)
        {
            return _context.OT.Any(e => e.OTID == id);
        }
    }
}
