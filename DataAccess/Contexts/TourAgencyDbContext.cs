using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public partial class TourAgencyDbContext:DbContext
    {
        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Car> Cars { get; set; }
        public  DbSet<Payment> Payments { get; set; }
        public  DbSet<PaymentMethod> PaymentMethods { get; set; }
        public  DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public TourAgencyDbContext(DbContextOptions<TourAgencyDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Payment>()
                .ToTable("Payments")
                .Property(e=>e.Status)
                .HasConversion<string>();
            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethods");
            modelBuilder.Entity<PaymentTransaction>()
                .ToTable("PaymentTransactions")
                .Property(e => e.TransactionType)
                .HasConversion<string>()
                .HasColumnType("nvarchar(10)");
            modelBuilder.Entity<PaymentTransaction>()
                .HasIndex(p => new { p.PaymentId, p.PaymentMethodId, p.TransactionDate })
                .IsUnique(true);

            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Employee>().ToTable("Employees");
        }
    }
}
