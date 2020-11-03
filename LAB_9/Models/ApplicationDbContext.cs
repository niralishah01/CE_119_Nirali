using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using wddn_lab9.Models;

namespace wddn_lab9.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /* Domain classes */
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        /* Configuring Joining table properties */
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Order>()
                .HasKey(t => new { t.ID });

            /*builder.Entity<Order>()
                .Property(pt => pt.Amount);

            builder.Entity<Order>()
                .Property(pt => pt.Order_datetime);*/

            builder.Entity<Order>()
                .HasOne<Customer>(c => c.Customer)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.Cust_ID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Order>()
                .HasOne<Product>(p => p.Product)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.P_ID);

        }
    }
}
