using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DevEnvMVCHandIn.Models
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopFactory>
    {
        protected override void Seed(ShopFactory context)
        {
            context.Products.Add(new Product() { Name = "Blue Blouse", Description = "Girls choice", Price = 233, ImageName = "blue" });
            context.Products.Add(new Product() { Name = "Green Set", Description = "Boys choice", Price = 333, ImageName = "green" });
            context.Products.Add(new Product() { Name = "Wall Plant", Description = "Home decoration", Price = 122, ImageName = "dec" });

        }


    }
}