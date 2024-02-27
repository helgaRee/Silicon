using System.ComponentModel.DataAnnotations;

namespace Silicon_MVC.Models;
//detta är min basic-formulär i AccountDetailsViewModel-VYN
public class AccountDetailsBasicInfoModel
{


    [DataType(DataType.ImageUrl)]
    public string? ProfileImage { get; set; }


    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name is required")]
    public string Firstname { get; set; } = null!; //tvingande värde



    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Last name is required")]
    public string Lastname { get; set; } = null!;



    [Display(Name = "Email address", Prompt = "Enter your Email Address", Order = 2)]
    [DataType(DataType.EmailAddress)] //eller bara [EmailAddress]
    [MaxLength(50)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Your email address is invalid")]
    public string Email { get; set; } = null!;




    [Display(Name = "Phone", Prompt = "Enter your phone", Order = 3)]
    [DataType(DataType.PhoneNumber)]
    [Required(ErrorMessage = "Phone is required")]
    public string Phone { get; set; } = null!;






    [Display(Name = "Biography", Prompt = "Add a short bio...", Order = 4)]
    [DataType(DataType.MultilineText)]
    public string? Biography { get; set; }
}
