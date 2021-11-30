using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BillTracker.Models;

namespace BillTracker.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {
        }
        public DbSet<BillTracker.Models.Product> Product { get; set; }

    }
}
