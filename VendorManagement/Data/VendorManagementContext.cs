using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendorManagement.Models;

namespace VendorManagement.Data
{
    public class VendorManagementContext : DbContext
    {
        public VendorManagementContext (DbContextOptions<VendorManagementContext> options)
            : base(options)
        {
        }

        public DbSet<VendorManagement.Models.Vendors> Vendors { get; set; } = default!;
    }
}
