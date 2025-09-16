using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWEBMVC.Models;

namespace SalesWEBMVC.Data
{
    public class SalesWEBMVCContext : DbContext
    {
        public SalesWEBMVCContext (DbContextOptions<SalesWEBMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWEBMVC.Models.Department> Department { get; set; } = default!;
    }
}
