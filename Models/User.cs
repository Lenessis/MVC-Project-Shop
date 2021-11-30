using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace strona_internetowa_mvc.Models
{
    public class User
    {
        /* -- Variables - basic information about common user -- */

        public int UserId { get; set; }
        public string Login { get; set; }

        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Imię")]
        public string Firstname { get; set; }

        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; } // Możliwe, ze będzie wymagał nowej klasy
        public string Email { get; set; }

        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }


    }
}