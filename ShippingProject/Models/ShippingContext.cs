using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ShippingProject.Models
{
    public class ShippingContext: DbContext
    {
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Order> Employee_Orders { get; set; }
        public virtual DbSet<Governates> Governates { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<representive> representives { get; set; }
        public virtual DbSet<Setting_shipping> Setting_shippings { get; set; }
        public virtual DbSet<Setting_Weight> Setting_Weights { get; set; }
        public virtual DbSet<Special_Price_Trader> Special_Price_Traders { get; set; }
        public virtual DbSet<Trader> Traders { get; set; }
        public virtual DbSet<Type_Of_Paid> Type_Of_Paids { get; set; }
        public virtual DbSet<Type_Of_Shipping> Type_Of_Shippings { get; set; }  


        
        public ShippingContext(DbContextOptions<ShippingContext> options)
               : base(options)
        {
        }
    }
}
