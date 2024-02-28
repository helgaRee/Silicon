using Silicon_MVC.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Silicon_MVC.Models;

public class SignUpModel

{
    [DataType(DataType.Text)]
    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name is required")]
    [MinLength(2, ErrorMessage = "Enter a first name")]
    public string Firstname { get; set; } = null!; //tvingande värde





    [DataType(DataType.Text)]
    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Last name is required")]
    [MinLength(2, ErrorMessage = "Enter a last name")]
    public string Lastname { get; set; } = null!;





    [Display(Name = "Email address", Prompt = "Enter your Email Address", Order = 2)]
    [DataType(DataType.EmailAddress)] //eller bara [EmailAddress]
    [MaxLength(50)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Your email address is invalid")]
    public string Email { get; set; } = null!;






    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password", Order = 3)]
    [Required(ErrorMessage = "Password is required")]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$", ErrorMessage = "Invalid Password, must be a strong password.")]
    public string Password { get; set; } = null!;




    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password", Prompt = "Confirm your password", Order = 4)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Fields doesnt match")]
    public string ConfirmPassword { get; set; } = null!;




    [Display(Name = "I agree to the Terms & Conditions.", Order = 5)]
    [CheckBoxRequired(ErrorMessage = "You must accept the Terms & Conditions to continue.")]

    public bool TermsAndConditions { get; set; } = false;






}
