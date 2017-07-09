using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using SportStore.Domain.Entities;

namespace SportStore.DB
{
    public class SportStoreInitializer:DropCreateDatabaseIfModelChanges<SportStoreContext>
    {

       
        protected override void Seed(SportStoreContext context)
        {
            var products = new List<Product>
            {
                new Product {  Description="Description", Name="Ball", Price=10},
                new Product {  Description="Description 1", Name="Pen", Price=10},
                new Product { Description="Description", Name="Apple", Price=10},
                new Product { Description="Description 3", Name="Orange", Price=10},
                new Product { Description="Description", Name="Watch", Price=10},
                new Product { Description="Description", Name="Mobile", Price=10},
                new Product { Description="Description", Name="Laptop", Price=10},
                new Product { Description="Description", Name="Rice", Price=10},
                new Product { Description="Description", Name="Bred", Price=10},
                new Product { Description="Description", Name="Juice", Price=10},
                new Product { Description="Description", Name="Meat", Price=10}
            };

            products.ForEach(m => context.Products.Add(m));
            context.SaveChanges();
        }
    }
}
