using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace strona_internetowa_mvc.Models
{
    public class Product
    {
        /* -- Variables - basic information about any product -- */
        public int ProductId { get; set; }
        [DisplayName("Nazwa")]
        public string ProductName { get; set; }
        //public string ProductImage { get; set; } //Base64
        [DisplayName("Opis produktu")]
        public string Description { get; set; }
        [DisplayName("Ilość sztuk")]
        public int Amount { get; set; }
        //public List<string> ProductColor { get; set; } // Być moze będzie potrzebna dodatkowa klasa
        //public boolean Avaible ??? 
    }
}