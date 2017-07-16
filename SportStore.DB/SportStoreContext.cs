using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SportStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SportStore.DB
{
    public class SportStoreContext:DbContext
    {
        public SportStoreContext() : base("name=Constr")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

       
        public DbSet<Product> Products { get; set; }
        public DbSet<ShippingDetails> ShippingDetails { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);
        }
    }
}
