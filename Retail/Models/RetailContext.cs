using Microsoft.EntityFrameworkCore;
using Retail.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Models
{
  public class RetailContext : DbContext
  {
    public RetailContext(DbContextOptions<RetailContext> options) : base(options)
    {

    }
    public DbSet<Login> Login { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<Outlet> Outlet { get; set; }
    public DbSet<Gst> Gst { get; set; }
    public DbSet<Product> Product { get; set; }
        public DbSet<Spec> Spec { get; set; }
        public DbSet<Category> Category  { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<LocalInventory> LocalInventory { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
    }
}
