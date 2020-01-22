using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk.Pages.listOTs
{
    public class CreateOTModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;
        
        public CreateOTModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }
        public Employee Employee { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            Employee = await _context.Employee
            .Include(e => e.Company)
            .Include(e => e.Department)
            .Include(e => e.EmployeeType)
            .Include(e => e.Location)
            .Include(e => e.Position).FirstOrDefaultAsync(m => m.EmployeeID == id);

            

            return Page();
        }

        [BindProperty]
        public OT OT { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            DateTime datenew = OT.date;
            int newyear = OT.date.Year + 543;
            OT.date =  new DateTime(newyear, datenew.Month, datenew.Day);
            string date = OT.date.ToString("dddd");
            OT.TypeOT = date;



            _context.OT.Add(OT);
            await _context.SaveChangesAsync();

            return RedirectToPage("./../listOTs/manageOT", new { id = id });
        }
    }
}
