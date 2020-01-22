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
    public class detailOTViewModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public detailOTViewModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }

        public DetailOT DetailOT { get; set; }
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DetailOT = await _context.DetailOT
               
                .Include(d => d.Employee)
                .Include(d => d.FoodSet)
                .Include(d => d.OT)
                .Include(d => d.Part).FirstOrDefaultAsync(m => m.DetailOTID == id);

            Employee = await _context.Employee
                .Include(e => e.Company)
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .Include(e => e.Location)
                .Include(e => e.Position).FirstOrDefaultAsync(e => e.EmployeeID == DetailOT.Employee_EmpID);

            if (DetailOT == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

