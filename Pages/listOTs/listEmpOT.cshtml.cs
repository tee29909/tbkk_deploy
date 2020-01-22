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
    public class listEmpOTModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public listEmpOTModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }

        
        public IList<DetailOT> DetailOT { get;set; }
        public IList<OT> OT { get; set; }
        public Employee Employee { get; set; }

        public async Task OnGetAsync(int? id)
        {
            await OnLoad(id);

        }

        private async Task OnLoad(int? id)
        {
            Employee = await _context.Employee
              .Include(e => e.Company)
              .Include(e => e.Department)
              .Include(e => e.EmployeeType)
              .Include(e => e.Location)
              .Include(e => e.Position).FirstOrDefaultAsync(m => m.EmployeeID == id);
            DetailOT = await _context.DetailOT

                .Include(d => d.Employee)
                .Include(d => d.FoodSet)
                .Include(d => d.OT)
                .Include(d => d.Part).ToListAsync();
            DetailOT = DetailOT.Where(d => d.Employee.Employee_DepartmentID == Employee.Employee_DepartmentID).ToList();
            DetailOT = DetailOT.Where(d => d.Status.Equals("Pending for approval")).ToList();
            OT = await _context.OT.ToListAsync();
            OT = OT.Where(o => o.TypStatus.Equals("Manage Car")).ToList();
        }

        public async Task<IActionResult> OnPostAddAllAsync(int id, int Did)
        {
            await OnLoad(id);
            List<DetailOT> newDetailOTs = DetailOT.Where(n => n.OT_OTID == Did).ToList();
            foreach (var item in newDetailOTs)
            {
                DetailOT newDetailOT = item;
                newDetailOT.Status = "Allow";

                _context.Attach(newDetailOT).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetailOTExists(newDetailOT.DetailOTID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            

            return RedirectToPage("./../listOTs/listEmpOT", new { id = Employee.EmployeeID });
        }

        private bool DetailOTExists(int id)
        {
            return _context.DetailOT.Any(e => e.DetailOTID == id);
        }
    }
}
