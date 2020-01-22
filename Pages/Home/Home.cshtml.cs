using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk.Pages.Home
{
    public class HomeModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;
        public HomeModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            Employee = HttpContext.Session.GetLogin(_context.Employee);
            
           
            //id = HttpContext.Session.GetID();
            //Employee = await _context.Employee
            //     .Include(e => e.Company)
            //    .Include(e => e.Department)
            //    .Include(e => e.EmployeeType)
            //    .Include(e => e.Location)
            //    .Include(e => e.Position)
            //    .FirstOrDefaultAsync(m => m.EmployeeID == id);
            //return RedirectToPage("./../Home/Home", new { id = Employee.EmployeeID });
            return Page();
        }
    }
}