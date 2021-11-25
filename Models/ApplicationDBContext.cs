using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillTracker.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {
        }

    }
}
