using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApplication.Context
{
    public class CustomerDBContext : DbContext
    { 
        public CustomerDBContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<CustomerAddress>()
                .HasKey(bc => new { bc.CustomerId, bc.AddressId });
            model.Entity<CustomerAddress>()
                .HasOne(bc => bc.Customer)
                .WithMany(b => b.CustomerAddresses)
                .HasForeignKey(bc => bc.CustomerId);
            model.Entity<CustomerAddress>()
                .HasOne(bc => bc.Address)
                .WithMany(c => c.CustomerAddresses)
                .HasForeignKey(bc => bc.AddressId);
        }
    }
}
