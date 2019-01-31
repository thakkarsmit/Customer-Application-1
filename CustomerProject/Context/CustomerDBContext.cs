using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data; // Entity.ModelConfiguration.Configuration;

namespace CustomerProject.Context
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddress>()
                .HasKey(bc => new { bc.CustomerId, bc.AddressId });
            modelBuilder.Entity<CustomerAddress>()
                .HasOne(bc => bc.Customer)
                .WithMany(b => b.CustomerAddresses)
                .HasForeignKey(bc => bc.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CustomerAddress>()
                .HasOne(bc => bc.Address)
                .WithMany(c => c.CustomerAddresses)
                .HasForeignKey(bc => bc.AddressId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
