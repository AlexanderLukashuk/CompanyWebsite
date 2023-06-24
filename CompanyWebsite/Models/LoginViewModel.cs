using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyWebsite.Models
{
	public class LoginViewModel
	{
		[Required]
		[Display(Name = "Login")]
		public string? UserName { get; set; }

        [Required]
		[UIHint("password")]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Display(Name = "Remember the password?")]
        public bool RememberPassword { get; set; }
    }
}

