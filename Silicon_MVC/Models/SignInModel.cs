﻿using System.ComponentModel.DataAnnotations;

namespace Silicon_MVC.Models;

public class SignInModel
{

    [Display(Name = "Email address", Prompt = "Enter your Email Address", Order = 0)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; } = null!;




    [Display(Name = "Password", Prompt = "Enter your password", Order = 1)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = null!;



    [Display(Name = "Remember me", Order = 2)]
    public bool RememberMe { get; set; }
}
