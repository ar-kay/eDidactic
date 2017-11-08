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
}