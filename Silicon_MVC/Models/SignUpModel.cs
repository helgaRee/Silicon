using Silicon_MVC.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Silicon_MVC.Models;

public class SignUpModel

{
    [DataType(DataType.Text)]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "First name is required")]
    public string Firstname { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name")]
    [Required(ErrorMessage = "Last name is required")]
    public string Lastname { get; set; } = null!;


    [Display(Name = "Email address", Prompt = "Enter your Email Address")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; } = null!;


    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [Required(ErrorMessage = "Enter a valid password")]
    public string Password { get; set; } = null!;


    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password", Prompt = "Confirm your password")]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Fields doesnt match")]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "I agree to the Terms & Conditions.", Order = 5)]
    [CheckBoxRequired(ErrorMessage = "You must accept the Terms & Conditions to continue.")]

    public bool TermsAndConditions { get; set; } = false;

}
