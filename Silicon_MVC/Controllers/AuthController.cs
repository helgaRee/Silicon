using Microsoft.AspNetCore.Mvc;

namespace Silicon_MVC.Controllers;

public class AuthController : Controller
{
    //Genom att ange Route, behöver man inte nå sig up via auth: /auth/aignup
    //utan det räcker med /signup
    [Route("/signup")]
    //IActionResult ger mig tillgång till vyer, parital vyer, statuskoder osv
    public IActionResult SignUp()
    {
        return View();
    }
}
