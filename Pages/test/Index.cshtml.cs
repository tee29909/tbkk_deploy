using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk
{
    public class IndexModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public IndexModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }

        public IList<DetailCarQueue> DetailCarQueue { get;set; }

        public async Task OnGetAsync()
        {
            DetailCarQueue = await _context.DetailCarQueue
                .Include(d => d.CarQueue)
                .Include(d => d.Employee).ToListAsync();
        }
    }
}
