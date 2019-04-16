using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace MyShop.Models
{
    public class User : IdentityUser
    {
        [Required (ErrorMessage="Укажите имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Укажите Фамилию")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Укажите Отчество")]
        public string MiddleName { get; set; }
        
    }
}
