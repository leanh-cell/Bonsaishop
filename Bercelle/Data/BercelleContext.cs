using System;
using Bercelle.Models;
using Microsoft.EntityFrameworkCore;

namespace Bercelle.Data
{
    public class BercelleContext : DbContext
    {

        public BercelleContext(DbContextOptions<BercelleContext> options) : base(options)
        {
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Cart>().ToTable("Cart");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail");
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}