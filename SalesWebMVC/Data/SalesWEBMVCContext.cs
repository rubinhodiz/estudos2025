
using Microsoft.EntityFrameworkCore;
using SalesWEBMvc.Models;



namespace SalesWEBMVC.Data
{
    public class SalesWEBMVCContext : DbContext
    {
        public SalesWEBMVCContext (DbContextOptions<SalesWEBMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWEBMvc.Models.Department> Department { get; set; }
        public DbSet <Seller> Seller { get; set; }
        public DbSet <SalesRecord> SalesRecord { get; set; }

    }
}
