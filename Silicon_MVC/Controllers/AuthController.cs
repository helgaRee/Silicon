using Microsoft.AspNetCore.Mvc;

namespace Silicon_MVC.Controllers;

public class AuthController : Controller
{
    public IActionResult SignUp()
    {
        return View();
    }
}
