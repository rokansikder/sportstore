namespace SportStore.DB.Migrations
{
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SportStore.DB.SportStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SportStore.DB.SportStoreContext";
        }

        protected override void Seed(SportStore.DB.SportStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //var products = new List<Product>
            //{
            //    new Product {  Description="Description", Name="Ball", Price=10},
            //    new Product { Description="Description 1", Name="Pen", Price=10},
            //    new Product { Description="Description", Name="Apple", Price=10},
            //    new Product {  Description="Description 3", Name="Orange", Price=10},
            //    new Product { Description="Description", Name="Watch", Price=10},
            //    new Product {  Description="Description", Name="Mobile", Price=10},
            //    new Product {  Description="Description", Name="Laptop", Price=10},
            //    new Product {  Description="Description", Name="Rice", Price=10},
            //    new Product {  Description="Description", Name="Bred", Price=10},
            //    new Product {  Description="Description", Name="Juice", Price=10},
            //    new Product {  Description="Description", Name="Meat", Price=10}
            //};

            //products.ForEach(m => context.Products.Add(m));
            //context.SaveChanges();
        }
    }
}
