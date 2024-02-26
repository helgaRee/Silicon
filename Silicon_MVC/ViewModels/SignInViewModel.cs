using Silicon_MVC.Models;

namespace Silicon_MVC.ViewModels;

public class SignInViewModel
{
    public string Title { get; set; } = "Sign in";

    public SignInModel Form { get; set; } = new SignInModel();

    public string? ErrorMessage { get; set; }

}
