using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Data.Entity;

namespace DevEnvMVCHandIn.Models
{
    public class ShopFactory : DbContext
    {
        public ShopFactory()
        {
            Database.SetInitializer(new ShopInitializer());
        }

        public DbSet<Product> Products { get; set; }
    }
}