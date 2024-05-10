using Microsoft.EntityFrameworkCore;

namespace ChainOfResp.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AYASINB\\AYASINB;initial Catalog=ChainOfDb;integrated security=true");
        }

        public DbSet<CustomerProcess> CustomerProcess { get; set; }
    }
}
