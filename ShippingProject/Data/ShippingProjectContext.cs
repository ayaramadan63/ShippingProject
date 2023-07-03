using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShippingProject.Models;

namespace ShippingProject.Data
{
    public class ShippingProjectContext : DbContext
    {
        public ShippingProjectContext (DbContextOptions<ShippingProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ShippingProject.Models.Governates> Governates { get; set; } = default!;
    }
}
