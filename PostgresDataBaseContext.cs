using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CheckReport
{
    public partial class PostgresDataBaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        
        public DbSet<ProductInOrder> ProductsInOrders { get; set; }

        public PostgresDataBaseContext()
        {
        }

        public PostgresDataBaseContext(DbContextOptions<PostgresDataBaseContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql(
                    "Host=localhost;Port=5432;Database=ChecksReports;Username=postgres;Password=admin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_United Kingdom.1251");

            OnModelCreatingPartial(modelBuilder);

            modelBuilder
                .Entity<ProductInOrder>()
                .HasOne(po => po.Product)
                .WithMany(p => p.ProductInOrders)
                .HasForeignKey(po => po.ProductId);
            
            modelBuilder.Entity<ProductInOrder>()
                .HasOne(po => po.Order)
                .WithMany(o => o.ProductInOrders)
                .HasForeignKey(po => po.OrderId);
            
            modelBuilder.Entity<ProductInOrder>()
                .HasKey(po => new {po.OrderId, po.ProductId});
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}