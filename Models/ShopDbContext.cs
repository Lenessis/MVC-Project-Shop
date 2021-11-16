using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace strona_internetowa_mvc.Models
{
    public class ShopDbContext:DbContext
    {
        public ShopDbContext() : base("shop") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}