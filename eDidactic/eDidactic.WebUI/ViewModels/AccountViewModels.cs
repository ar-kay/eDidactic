using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eDidactic.WebUI.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić login")] 
        public string Login { get; set; }

        [Required(ErrorMessage = "Muszisz wprowadzić hasło")]
        public string Password { get; set; }

        [Display(Name ="Zapamiętaj mnie")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić hasło")]
        [StringLength(100, ErrorMessage = "Hasło musi mieć przynajmeniej {2} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hasła nie są równe.")]
        public string ConfirmPassword { get; set; }
    }
}