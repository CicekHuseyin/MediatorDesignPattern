using Microsoft.EntityFrameworkCore;

namespace InspimoMediatorDesignPattern.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KR485FT\\SQLEXPRESS; initial catalog=DbMediatorPattern; integrated security=true"); ;
        }
        public DbSet<Product> Products { get; set; }
    }
}
