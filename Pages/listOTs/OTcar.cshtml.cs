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
    public class OTcarModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public OTcarModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }
        public IList<OT> OT { get;set; }

        public async Task OnGetAsync(int? id)
        {
            string TypStatus = "Close";
            OT = await _context.OT.ToListAsync();
            OT = OT.Where(o => o.TypStatus.Equals(TypStatus)).ToList();

            Employee = await _context.Employee
                .Include(e => e.Company)
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .Include(e => e.Location)
                .Include(e => e.Position).FirstOrDefaultAsync(m => m.EmployeeID == id);

        }
    }
}
