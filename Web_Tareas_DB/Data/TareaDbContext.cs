using Microsoft.EntityFrameworkCore;
using Web_Tareas_DB.Models;
namespace Web_Tareas_DB.Data
{
    public class TareaDbContext:DbContext
    {
       
        public TareaDbContext(DbContextOptions<TareaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }
    }

}

