using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext:DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
       {
        
       } 

       public DbSet<Note> Notes { get; set; }

       
    }
}