using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace strona_internetowa_mvc.Models
{
    public class User
    {
        /* -- Variables - basic information about common user -- */

        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; } // Możliwe, ze będzie wymagał nowej klasy
        public string Email { get; set; }
        public string PhoneNumber { get; set; }




    }
}