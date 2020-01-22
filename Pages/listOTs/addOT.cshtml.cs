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
    public class addOTModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public addOTModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public DetailOT DetailOT { get; set; }

        public OT OT { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.

        public Employee Employee { get; set; }
        public IList<FoodSet> FoodSet { get; set; }
        

        public async Task<IActionResult> OnGetAsync(int? id,int? Did)
        {

            if (id == null)
            {
                return NotFound();
            }

            await onLoad(id, Did); 
            if (OT == null)
            {
                return NotFound();
            }


            if (Employee == null)
            {
                return NotFound();
            }

            return Page();
        }

        private async Task onLoad(int? id, int? Did)
        {
            Employee = await _context.Employee
             .Include(e => e.Company)
             .Include(e => e.Department)
             .Include(e => e.EmployeeType)
             .Include(e => e.Location)
             .Include(e => e.Position).FirstOrDefaultAsync(m => m.EmployeeID == id);
            OT = await _context.OT.FirstOrDefaultAsync(m => m.OTID == Did);


            ViewData["CarType_CarTypeID"] = new SelectList(_context.CarType, "CarTypeID", "NameCar");
            ViewData["Employee_EmpID"] = new SelectList(_context.Employee, "EmployeeID", "EmployeeID");
            ViewData["FoodSet_FoodSetID"] = new SelectList(_context.FoodSet, "FoodSetID", "NameSet");
            ViewData["OT_OTID"] = new SelectList(_context.OT, "OTID", "OTID");
            ViewData["Part_PaetID"] = new SelectList(_context.Part, "PartID", "Name");
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {

                return Page();
            }
            OT = await _context.OT.FirstOrDefaultAsync(e => e.OTID == DetailOT.OT_OTID);

            DateTime TimeS = OT.TimeStart;
            DetailOT.TimeStart = new DateTime(TimeS.Year, TimeS.Month, TimeS.Day, DetailOT.TimeStart.Hour, DetailOT.TimeStart.Minute, DetailOT.TimeStart.Second);
            DetailOT.TimeEnd = new DateTime(TimeS.Year, TimeS.Month, TimeS.Day, DetailOT.TimeEnd.Hour, DetailOT.TimeEnd.Minute, DetailOT.TimeEnd.Second);
            TimeSpan hour = DetailOT.TimeEnd - DetailOT.TimeStart;
            DetailOT.Hour = hour;


            int check = 0;
            check = checkTime(check);
            if (check == 1)
            {
                await returnPage();
                return Page();
            }

            _context.DetailOT.Add(DetailOT);
            await _context.SaveChangesAsync();
            





            return RedirectToPage("./../listOTs/listOT", new { id = DetailOT.Employee_EmpID });

        }

        private int checkTime(int check)
        {
            if (DetailOT.TimeStart == DetailOT.TimeEnd)
            {
                ModelState.AddModelError("timeError1", "The start time is less than the end time.");
                ModelState.AddModelError("timeError2", "The start time is less than the end time.");
                check = 1;

            }

            if (!DetailOT.Type.Equals("No") && DetailOT.Part_PaetID == 1)
            {
                check = 1;
                ModelState.AddModelError("partError", "Please select a route.");

            }


            if (!(OT.TypeOT.Equals("Sunday") || OT.TypeOT.Equals("Saturday")) && DetailOT.TimeStart.Hour < 17)
            {
                check = 1;
                ModelState.AddModelError("timeError1", "Time to start working overtime at 17.00 o'clock.");

            }


            if (!(OT.TypeOT.Equals("Sunday") || OT.TypeOT.Equals("Saturday")) && DetailOT.TimeEnd.Hour < 17)
            {
                check = 1;
                ModelState.AddModelError("timeError2", "Time to start working overtime at 17.00 o'clock.");

            }
            ////
            ///
            if ((OT.TypeOT.Equals("Sunday") || OT.TypeOT.Equals("Saturday")) && DetailOT.TimeStart.Hour < 8)
            {
                check = 1;
                ModelState.AddModelError("timeError1", "Time to start working overtime at 8.00 o'clock.");

            }

            if ((OT.TypeOT.Equals("Sunday") || OT.TypeOT.Equals("Saturday")) && DetailOT.TimeEnd.Hour < 8)
            {
                check = 1;
                ModelState.AddModelError("timeError2", "Time to start working overtime at 8.00 o'clock.");

            }




            return check;
        }

        private async Task returnPage()
        {
            Employee = await _context.Employee.Include(e => e.Company)
                         .Include(e => e.Department)
                         .Include(e => e.EmployeeType)
                         .Include(e => e.Location)
                         .Include(e => e.Position).FirstOrDefaultAsync(e => e.EmployeeID == DetailOT.Employee_EmpID);
            



            ViewData["CarType_CarTypeID"] = new SelectList(_context.CarType, "CarTypeID", "NameCar");
            ViewData["Employee_EmpID"] = new SelectList(_context.Employee, "EmployeeID", "EmployeeID");
            ViewData["FoodSet_FoodSetID"] = new SelectList(_context.FoodSet, "FoodSetID", "NameSet");
            ViewData["OT_OTID"] = new SelectList(_context.OT, "OTID", "OTID");
            ViewData["Part_PaetID"] = new SelectList(_context.Part, "PartID", "Name");
            
        }

    }
}
