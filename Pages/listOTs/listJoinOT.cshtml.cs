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
    public class listJoinOTModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;
          
        public listJoinOTModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }
        
        public IList<DetailOT> DetailOT { get;set; }

        public TimeSpan countHourOT { get; set; }







        public async Task<IActionResult> OnGetAsync(int? id )
        {
            if (id == null)
            {
                return NotFound();
            }
            

           
           

            DetailOT = await _context.DetailOT
                
                .Include(d => d.Employee)
                .Include(d => d.FoodSet)
                .Include(d => d.OT)
                .Include(d => d.Part).ToListAsync();

            DetailOT = DetailOT.Where(d => d.Employee_EmpID.Equals(id)).ToList();
            DetailOT = DetailOT.Where(d => d.Status.Equals("Approved")).ToList();
            countHourOT = new TimeSpan();
            foreach (var item in DetailOT)
            {
                countHourOT = countHourOT + item.Hour;
            }

            

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
    }
}
