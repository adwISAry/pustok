using Microsoft.EntityFrameworkCore;
using pustok.CoreModels;

namespace pustok.Context
{
    public class ApplicationDbContext : DbContext
    {
        public  DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-R4EGFJU\SQLEXPRESS ;Database = Pustokdb; Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
