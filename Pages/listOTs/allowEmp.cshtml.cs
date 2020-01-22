using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk.Pages.listOTs
{
    public class allowEmpModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public allowEmpModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }
        public IList<DetailOT>  DetailOT { get; set; }
        public Employee Employee { get; set; }
        public DetailOT DetailOTs { get; set; }



        public async Task<IActionResult> OnGetAsync(int? id, int? Did)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            Employee = await _context.Employee
                
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .Include(e => e.Location)
                .Include(e => e.Position).FirstOrDefaultAsync(e => e.EmployeeID == id);

            DetailOT = await _context.DetailOT
                
                .Include(d => d.Employee)
                .Include(d => d.FoodSet)
                .Include(d => d.OT)
                .Include(d => d.Part).Where(d => d.OT_OTID == Did).ToListAsync();
            DetailOT = DetailOT.Where(d => d.Employee.Employee_DepartmentID == Employee.Employee_DepartmentID).ToList();

            if (DetailOT == null)
            {
                return NotFound();
            }
            
            return Page();
        }

        public async Task<IActionResult> OnPostRemoveAsync(int id, int Did)
        {
            
            DetailOTs = await _context.DetailOT
               
               .Include(d => d.Employee)
               .Include(d => d.FoodSet)
               .Include(d => d.OT)
               .Include(d => d.Part).FirstOrDefaultAsync(e => e.DetailOTID == Did);
            DetailOTs.Status = "Disallow";
            _context.Attach(DetailOTs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetailOTExists(DetailOTs.DetailOTID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            Employee = await _context.Employee
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .Include(e => e.Location)
                .Include(e => e.Position).FirstOrDefaultAsync(e => e.EmployeeID == id);

            DetailOT = await _context.DetailOT
               
               .Include(d => d.Employee)
               .Include(d => d.FoodSet)
               .Include(d => d.OT)
               .Include(d => d.Part).Where(d => d.OT_OTID == DetailOTs.OT_OTID).ToListAsync();
            DetailOT = DetailOT.Where(d => d.Employee.Employee_DepartmentID == Employee.Employee_DepartmentID).ToList();

            return Page();
        }

        public async Task<IActionResult> OnPostAllowAsync(int id, int Did)
        {

            DetailOTs = await _context.DetailOT
               
               .Include(d => d.Employee)
               .Include(d => d.FoodSet)
               .Include(d => d.OT)
               .Include(d => d.Part).FirstOrDefaultAsync(e => e.DetailOTID == Did);
            DetailOTs.Status = "Allow";
            _context.Attach(DetailOTs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetailOTExists(DetailOTs.DetailOTID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            Employee = await _context.Employee
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .Include(e => e.Location)
                .Include(e => e.Position).FirstOrDefaultAsync(e => e.EmployeeID == id);

            DetailOT = await _context.DetailOT
               
               .Include(d => d.Employee)
               .Include(d => d.FoodSet)
               .Include(d => d.OT)
               .Include(d => d.Part).Where(d => d.OT_OTID == DetailOTs.OT_OTID).ToListAsync();
            DetailOT = DetailOT.Where(d => d.Employee.Employee_DepartmentID == Employee.Employee_DepartmentID).ToList();

            return Page();
        }

        private bool DetailOTExists(int id)
        {
            return _context.DetailOT.Any(e => e.DetailOTID == id);
        }
    }
}
