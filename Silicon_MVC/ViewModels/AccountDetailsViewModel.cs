using Silicon_MVC.Models;

namespace Silicon_MVC.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";

    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        //kan här hämta information från min databas, in till mitt system.
        ProfileImage = "~/images/profile-image.svg",
        Firstname = "Helga",
        Lastname = "Reesalu",
        Email = "helga@domain.com",
    };

    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();




}
