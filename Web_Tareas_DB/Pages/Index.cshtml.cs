using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_Tareas_DB.Data;
using Web_Tareas_DB.Models;

namespace Web_Tareas_DB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Web_Tareas_DB.Data.TareaDbContext _context;

        public IndexModel(Web_Tareas_DB.Data.TareaDbContext context)
        {
            _context = context;
        }

        public IList<Tarea> Tarea { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tarea = await _context.Tareas.ToListAsync();
        }
    }
}
